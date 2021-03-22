using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGraph
{
    public partial class Form1 : Form
    {
        Graphics GDC;
        public Form1()
        {
            InitializeComponent();

            GDC = CanvasDraw.CreateGraphics();
        }

        
        private void mnuDraw_Click(object sender, EventArgs e)
        {
           
        }

        private void canvasDraw_Paint(object sender, PaintEventArgs e)
        {
      
        }
        bool MStatus = false;  // false: 그리기 상태 아님, true: 그리기 상태
        int DrawMode = -1;     // -1:none / 0:pen / 1:circle / 2:Arc / 3:Line
        Point p1;
        Color Col = Color.Red;

        private void CanvasDraw_MouseDown(object sender, MouseEventArgs e)
        {

            if (DrawMode == 0)
            {
                p1 = new Point(e.X, e.Y);
                MStatus = true; //판별변수로 사용
            }
            else if (DrawMode == 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Pen pp = new Pen(Col, Thickness);
                    GDC.DrawEllipse(pp, e.X - cirX / 2, e.Y - cirY / 2, cirX, cirY);
                }
            }
            //GDC.DrawArc();
        }

        private void CanvasDraw_Resize(object sender, EventArgs e)
        {
            GDC = CanvasDraw.CreateGraphics();
        }

        int cirX = 10;
        int cirY = 10;
        int Thickness = 2;
        private void mnuOption_Click(object sender, EventArgs e)
        {
            FormOption dlg = new FormOption(cirX,cirY,Thickness);
            //dlg.X = cirX;  dlg.Y=cirY;    dlg.Thick=Thickness;
            DialogResult ret = dlg.ShowDialog();   
            if(ret==DialogResult.OK)
            {
                cirX = dlg.X;
                cirY = dlg.Y;
                Thickness = dlg.Thick;
                Col = dlg.Col1;
                sbPanel3.Text = $"{dlg.ColorName}.{Thickness}";
            }
        }
        
        private void mnuErase_Click(object sender, EventArgs e)
        {
            GDC.Clear(DefaultBackColor);
        }

        private void CanvasDraw_MouseMove(object sender, MouseEventArgs e)
        {
            //int x = e.X;
            //int y = e.Y;
            //string sx = $"{x}";
            //string sy = $"{y}";

            // 1. Mouse의 왼쪽버튼 클릭 시 그리기 Start
            // - 현재의 Point 값을 저장
            // 2. Mouse의 이동에 따라 발생하는 Move event에서
            // Line Draw 현재의 값을 재저장
            // 3. (2)번 동작을 반복
            // 4. Mouse의 왼쪽버튼이 해제되면 그리기 Stop

            if(DrawMode==0)
            {
                if(MStatus)
                {
                    Pen pp = new Pen(Col, Thickness);
                    Point p2 = new Point(e.X, e.Y);
                    GDC.DrawLine(pp, p1, p2);
                    p1 = p2;
                }           
            }
            sbPanel1.Text = $"{e.X},{e.Y}";
        }

        private void CanvasDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (DrawMode == 0)
            {
                MStatus = false;
            }
        }

        private void mnuDrawPen_Click(object sender, EventArgs e)
        {
            DrawMode = 0;
            sbPanel2.Text = "펜 그리기";
            sbPanel3.Text = $"{Col}.{Thickness}";
        }

        private void mnuDrawCircle_Click(object sender, EventArgs e)
        {
            DrawMode = 1;
            sbPanel2.Text = "원 그리기";
        }

        private void mnuDrawArc_Click(object sender, EventArgs e)
        {
            DrawMode = 2;
            sbPanel2.Text = "호(Arc) 그리기";
        }

        private void mnuDrawStop_Click(object sender, EventArgs e)
        {
            DrawMode = -1;
            sbPanel2.Text = "그리기 모드";
        }

        
    }
}
