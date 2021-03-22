
namespace WindowsFormsGraph
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbPanel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasDraw = new System.Windows.Forms.PictureBox();
            this.mnuDrawPen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawArc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.sbPanel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuDrawStop = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPanel1,
            this.sbPanel2,
            this.sbPanel3,
            this.sbPanel4});
            this.statusBar.Location = new System.Drawing.Point(0, 453);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(729, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbPanel1
            // 
            this.sbPanel1.Name = "sbPanel1";
            this.sbPanel1.Size = new System.Drawing.Size(24, 17);
            this.sbPanel1.Text = "0.0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDraw,
            this.mnuDrawStop,
            this.mnuErase,
            this.mnuOption});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // mnuDraw
            // 
            this.mnuDraw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrawPen,
            this.mnuDrawCircle,
            this.mnuDrawArc,
            this.mnuDrawLine});
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(180, 22);
            this.mnuDraw.Text = "그리기";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // mnuErase
            // 
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.Size = new System.Drawing.Size(180, 22);
            this.mnuErase.Text = "모두 지우기";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // mnuOption
            // 
            this.mnuOption.Name = "mnuOption";
            this.mnuOption.Size = new System.Drawing.Size(180, 22);
            this.mnuOption.Text = "옵션";
            this.mnuOption.Click += new System.EventHandler(this.mnuOption_Click);
            // 
            // CanvasDraw
            // 
            this.CanvasDraw.ContextMenuStrip = this.contextMenuStrip1;
            this.CanvasDraw.Location = new System.Drawing.Point(0, 2);
            this.CanvasDraw.Name = "CanvasDraw";
            this.CanvasDraw.Size = new System.Drawing.Size(729, 448);
            this.CanvasDraw.TabIndex = 3;
            this.CanvasDraw.TabStop = false;
            this.CanvasDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseDown);
            this.CanvasDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseMove);
            this.CanvasDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasDraw_MouseUp);
            this.CanvasDraw.Resize += new System.EventHandler(this.CanvasDraw_Resize);
            // 
            // mnuDrawPen
            // 
            this.mnuDrawPen.Name = "mnuDrawPen";
            this.mnuDrawPen.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawPen.Text = "연필 그리기";
            this.mnuDrawPen.Click += new System.EventHandler(this.mnuDrawPen_Click);
            // 
            // mnuDrawCircle
            // 
            this.mnuDrawCircle.Name = "mnuDrawCircle";
            this.mnuDrawCircle.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawCircle.Text = "원 그리기";
            this.mnuDrawCircle.Click += new System.EventHandler(this.mnuDrawCircle_Click);
            // 
            // mnuDrawArc
            // 
            this.mnuDrawArc.Enabled = false;
            this.mnuDrawArc.Name = "mnuDrawArc";
            this.mnuDrawArc.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawArc.Text = "호(Arc) 그리기";
            this.mnuDrawArc.Click += new System.EventHandler(this.mnuDrawArc_Click);
            // 
            // mnuDrawLine
            // 
            this.mnuDrawLine.Name = "mnuDrawLine";
            this.mnuDrawLine.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawLine.Text = "Line 그리기";
            // 
            // sbPanel2
            // 
            this.sbPanel2.Name = "sbPanel2";
            this.sbPanel2.Size = new System.Drawing.Size(67, 17);
            this.sbPanel2.Text = "그리기모드";
            // 
            // sbPanel3
            // 
            this.sbPanel3.Name = "sbPanel3";
            this.sbPanel3.Size = new System.Drawing.Size(52, 17);
            this.sbPanel3.Text = "Pen Info";
            // 
            // sbPanel4
            // 
            this.sbPanel4.Name = "sbPanel4";
            this.sbPanel4.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuDrawStop
            // 
            this.mnuDrawStop.Name = "mnuDrawStop";
            this.mnuDrawStop.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawStop.Text = "그리기 중지";
            this.mnuDrawStop.Click += new System.EventHandler(this.mnuDrawStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 475);
            this.Controls.Add(this.CanvasDraw);
            this.Controls.Add(this.statusBar);
            this.Name = "Form1";
            this.Text = "그림판";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.PictureBox CanvasDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.ToolStripMenuItem mnuOption;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawPen;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawCircle;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawArc;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawLine;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel2;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel3;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel4;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawStop;
    }
}

