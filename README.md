# 210322-DB
C#과 DB 활용하기

```

Form1.cs
    using myLibrary;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace WindowsFormsEdit
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
        
     //       int Count(char deli, string str)    // str 문자열의 deli 구분자의 개수 + 1
     //       {
     //           string[] Strs = str.Split(deli);
     //           int n = Strs.Length;
     //           return n - 1;
     //       }
     //       string GetToKen(int index, char deli, string str)
     //       {
     //           string[] Strs = str.Split(deli);
     ////           int n = Strs.Length;
     //           string ret = Strs[index];
     //           return ret;
     //       }

            private void mnuFileOpen_Click(object sender, EventArgs e)
            {
                DialogResult ret = openFileDialog1.ShowDialog();   // C++  DoModal
                if (ret == DialogResult.OK)
                {
                    string fName = openFileDialog1.FileName;        // full path
                    string fName1 = openFileDialog1.SafeFileName;   // file name only
                    StreamReader sr = new StreamReader(fName);      // class 를 선언할때는 new keyword를 이용해서 생상자를 표시해주어야 한다
                                                                    // 즉 c:FILE*    c++:CFile에 대응되는 C#에서 read를 위한 file open class이다.
                    string buf = sr.ReadToEnd();
                    tbMemo.Text = buf;
                    sr.Close();
                    int n = myLib.Count('\\', fName);       // fName에서의 '\\' 갯수
                    string fName2 = myLib.GetToKen(n, '\\', fName);   // fName에서 마지막 문자열
                    this.Text += $"     [{fName2}]";  // == 파일명
                }
            }

            // Save As...
            private void mnuFileSave_Click(object sender, EventArgs e)
            {
                DialogResult ret = saveFileDialog1.ShowDialog();
                if (ret == DialogResult.Cancel) return;

                string fName = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fName);

                string buf = tbMemo.Text;
                sw.Write(buf);
                sw.Close();
            }

            //  1. file open 후 Memo 창에 표시한 경우 - 확인(o) 수정(x)
            //  2. New 메뉴 선택 후 문서 편집         - file명 없음
            //  3. 기존 문서 중 일부 수정             - open file명 있음

            int txtChanged = 0;
            private void tbMemo_TextChanged(object sender, EventArgs e)
            {
            
                if (true) txtChanged = 1;
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                if (txtChanged == 1) 
                {

                }
            }

            private void mnuViewFont_Click(object sender, EventArgs e)
            {
                DialogResult ret = fontDialog1.ShowDialog();
                if (ret == DialogResult.Cancel) return;

                Font fnt = fontDialog1.Font;
                tbMemo.Font = fnt;

                //sbLabel1.Text = fnt.Name;
                //sbLabel2.Text = fnt.Size;
                SetFontInfo();

            }
            private void SetFontInfo()
            {
                sbLabel1.Text = tbMemo.Font.Name + $",  {tbMemo.Font.Height}";
            }

            private void mnuFileNew_Click(object sender, EventArgs e)
            {
                tbMemo.Text = null;
            }

            private void mnuLinechange_Click(object sender, EventArgs e)
            {
                tbMemo.WordWrap = false;
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                SetFontInfo();
            }

        string strSearch;
        string strOrigin;
        string strDest;
        int pos = -1;

        private void Search_Scroll(string strSearch1)
        {
            pos = tbMemo.Text.IndexOf(strSearch1, pos + 1); // tbMemo.Text = Target 문자열
            if (pos < 0)
            {
                MessageBox.Show("더 이상 해당 문자열을 찾을 수 없습니다.");
                return;
            }
            tbMemo.SelectionStart = pos;
            tbMemo.SelectionLength = strSearch1.Length;
            tbMemo.ScrollToCaret();
        }

        private void mnuEditSearch_Click(object sender, EventArgs e)
        {
            FormSearch dlg = new FormSearch();
            DialogResult ret = dlg.ShowDialog();
            if(ret == DialogResult.OK)          // 착한 사용자인 경우
            {
                strSearch = dlg.sSearch;        // 찾을 문자열
                Search_Scroll(strSearch);
            }
        }

        private void mnuEditContinue_Click(object sender, EventArgs e)
        {
            Search_Scroll(strSearch);
        }

        private void mnuEditReplace_Click(object sender, EventArgs e)
        {
            FormReplace dlg = new FormReplace();
            DialogResult ret = dlg.ShowDialog();
            if (ret == DialogResult.OK)          // 착한 사용자인 경우
            {
                strOrigin = dlg.sOrigin;
                strDest = dlg.sDest;

                tbMemo.Text = tbMemo.Text.Replace(strOrigin, strDest);
                Search_Scroll(strDest);
                strSearch = strDest;
            }
        }
    }
    }
```
