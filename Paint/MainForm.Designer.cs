namespace Paint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.btnPenMode = new System.Windows.Forms.Button();
            this.pnlColorList = new System.Windows.Forms.Panel();
            this.pnlColor7 = new System.Windows.Forms.Panel();
            this.pnlColor6 = new System.Windows.Forms.Panel();
            this.pnlColor5 = new System.Windows.Forms.Panel();
            this.pnlColor4 = new System.Windows.Forms.Panel();
            this.pnlColor3 = new System.Windows.Forms.Panel();
            this.pnlColor2 = new System.Windows.Forms.Panel();
            this.pnlColor1 = new System.Windows.Forms.Panel();
            this.pnlColor0 = new System.Windows.Forms.Panel();
            this.pnlSelColor = new System.Windows.Forms.Panel();
            this.pnlThicknessList = new System.Windows.Forms.Panel();
            this.lblThick4 = new System.Windows.Forms.Label();
            this.lblThick3 = new System.Windows.Forms.Label();
            this.lblThick2 = new System.Windows.Forms.Label();
            this.lblThick1 = new System.Windows.Forms.Label();
            this.lblThick0 = new System.Windows.Forms.Label();
            this.btnSquareMode = new System.Windows.Forms.Button();
            this.lblSelRect = new System.Windows.Forms.Label();
            this.btnCircleMode = new System.Windows.Forms.Button();
            this.btnOpBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.pnlColorList.SuspendLayout();
            this.pnlThicknessList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.BackColor = System.Drawing.Color.White;
            this.pbxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMain.Location = new System.Drawing.Point(150, 12);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(600, 500);
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            this.pbxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbxMain_MouseDown);
            this.pbxMain.MouseLeave += new System.EventHandler(this.PbxMain_MouseLeave);
            this.pbxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbxMain_MouseMove);
            this.pbxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbxMain_MouseUp);
            // 
            // timerDraw
            // 
            this.timerDraw.Interval = 32;
            this.timerDraw.Tick += new System.EventHandler(this.TimerDraw_Tick);
            // 
            // btnPenMode
            // 
            this.btnPenMode.Font = new System.Drawing.Font("Ricty Diminished", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPenMode.Image = ((System.Drawing.Image)(resources.GetObject("btnPenMode.Image")));
            this.btnPenMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPenMode.Location = new System.Drawing.Point(12, 12);
            this.btnPenMode.Name = "btnPenMode";
            this.btnPenMode.Size = new System.Drawing.Size(62, 57);
            this.btnPenMode.TabIndex = 1;
            this.btnPenMode.Text = "Pen";
            this.btnPenMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPenMode.UseVisualStyleBackColor = true;
            this.btnPenMode.Click += new System.EventHandler(this.BtnPenMode_Click);
            // 
            // pnlColorList
            // 
            this.pnlColorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColorList.Controls.Add(this.pnlColor7);
            this.pnlColorList.Controls.Add(this.pnlColor6);
            this.pnlColorList.Controls.Add(this.pnlColor5);
            this.pnlColorList.Controls.Add(this.pnlColor4);
            this.pnlColorList.Controls.Add(this.pnlColor3);
            this.pnlColorList.Controls.Add(this.pnlColor2);
            this.pnlColorList.Controls.Add(this.pnlColor1);
            this.pnlColorList.Controls.Add(this.pnlColor0);
            this.pnlColorList.Controls.Add(this.pnlSelColor);
            this.pnlColorList.Location = new System.Drawing.Point(12, 413);
            this.pnlColorList.Name = "pnlColorList";
            this.pnlColorList.Size = new System.Drawing.Size(121, 99);
            this.pnlColorList.TabIndex = 2;
            // 
            // pnlColor7
            // 
            this.pnlColor7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor7.Location = new System.Drawing.Point(88, 63);
            this.pnlColor7.Name = "pnlColor7";
            this.pnlColor7.Size = new System.Drawing.Size(20, 20);
            this.pnlColor7.TabIndex = 6;
            // 
            // pnlColor6
            // 
            this.pnlColor6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor6.Location = new System.Drawing.Point(62, 63);
            this.pnlColor6.Name = "pnlColor6";
            this.pnlColor6.Size = new System.Drawing.Size(20, 20);
            this.pnlColor6.TabIndex = 6;
            // 
            // pnlColor5
            // 
            this.pnlColor5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor5.Location = new System.Drawing.Point(36, 63);
            this.pnlColor5.Name = "pnlColor5";
            this.pnlColor5.Size = new System.Drawing.Size(20, 20);
            this.pnlColor5.TabIndex = 6;
            // 
            // pnlColor4
            // 
            this.pnlColor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor4.Location = new System.Drawing.Point(11, 63);
            this.pnlColor4.Name = "pnlColor4";
            this.pnlColor4.Size = new System.Drawing.Size(20, 20);
            this.pnlColor4.TabIndex = 8;
            // 
            // pnlColor3
            // 
            this.pnlColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor3.Location = new System.Drawing.Point(88, 37);
            this.pnlColor3.Name = "pnlColor3";
            this.pnlColor3.Size = new System.Drawing.Size(20, 20);
            this.pnlColor3.TabIndex = 7;
            // 
            // pnlColor2
            // 
            this.pnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor2.Location = new System.Drawing.Point(62, 37);
            this.pnlColor2.Name = "pnlColor2";
            this.pnlColor2.Size = new System.Drawing.Size(20, 20);
            this.pnlColor2.TabIndex = 6;
            // 
            // pnlColor1
            // 
            this.pnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor1.Location = new System.Drawing.Point(36, 37);
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Size = new System.Drawing.Size(20, 20);
            this.pnlColor1.TabIndex = 5;
            // 
            // pnlColor0
            // 
            this.pnlColor0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor0.Location = new System.Drawing.Point(11, 37);
            this.pnlColor0.Name = "pnlColor0";
            this.pnlColor0.Size = new System.Drawing.Size(20, 20);
            this.pnlColor0.TabIndex = 4;
            // 
            // pnlSelColor
            // 
            this.pnlSelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelColor.Location = new System.Drawing.Point(11, 11);
            this.pnlSelColor.Name = "pnlSelColor";
            this.pnlSelColor.Size = new System.Drawing.Size(20, 20);
            this.pnlSelColor.TabIndex = 3;
            // 
            // pnlThicknessList
            // 
            this.pnlThicknessList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlThicknessList.Controls.Add(this.lblThick4);
            this.pnlThicknessList.Controls.Add(this.lblThick3);
            this.pnlThicknessList.Controls.Add(this.lblThick2);
            this.pnlThicknessList.Controls.Add(this.lblThick1);
            this.pnlThicknessList.Controls.Add(this.lblThick0);
            this.pnlThicknessList.Location = new System.Drawing.Point(12, 248);
            this.pnlThicknessList.Name = "pnlThicknessList";
            this.pnlThicknessList.Size = new System.Drawing.Size(121, 159);
            this.pnlThicknessList.TabIndex = 9;
            // 
            // lblThick4
            // 
            this.lblThick4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThick4.Font = new System.Drawing.Font("Ricty Diminished", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblThick4.Location = new System.Drawing.Point(8, 126);
            this.lblThick4.Name = "lblThick4";
            this.lblThick4.Size = new System.Drawing.Size(100, 20);
            this.lblThick4.TabIndex = 4;
            this.lblThick4.Text = "xxpx";
            this.lblThick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThick3
            // 
            this.lblThick3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThick3.Font = new System.Drawing.Font("Ricty Diminished", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblThick3.Location = new System.Drawing.Point(8, 97);
            this.lblThick3.Name = "lblThick3";
            this.lblThick3.Size = new System.Drawing.Size(100, 20);
            this.lblThick3.TabIndex = 3;
            this.lblThick3.Text = "xxpx";
            this.lblThick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThick2
            // 
            this.lblThick2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThick2.Font = new System.Drawing.Font("Ricty Diminished", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblThick2.Location = new System.Drawing.Point(8, 68);
            this.lblThick2.Name = "lblThick2";
            this.lblThick2.Size = new System.Drawing.Size(100, 20);
            this.lblThick2.TabIndex = 2;
            this.lblThick2.Text = "xxpx";
            this.lblThick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThick1
            // 
            this.lblThick1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThick1.Font = new System.Drawing.Font("Ricty Diminished", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblThick1.Location = new System.Drawing.Point(8, 39);
            this.lblThick1.Name = "lblThick1";
            this.lblThick1.Size = new System.Drawing.Size(100, 20);
            this.lblThick1.TabIndex = 1;
            this.lblThick1.Text = "xxpx";
            this.lblThick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThick0
            // 
            this.lblThick0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThick0.Font = new System.Drawing.Font("Ricty Diminished", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblThick0.Location = new System.Drawing.Point(8, 9);
            this.lblThick0.Name = "lblThick0";
            this.lblThick0.Size = new System.Drawing.Size(100, 20);
            this.lblThick0.TabIndex = 0;
            this.lblThick0.Text = "xxpx";
            this.lblThick0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSquareMode
            // 
            this.btnSquareMode.Font = new System.Drawing.Font("Ricty Diminished", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSquareMode.Image = ((System.Drawing.Image)(resources.GetObject("btnSquareMode.Image")));
            this.btnSquareMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSquareMode.Location = new System.Drawing.Point(12, 75);
            this.btnSquareMode.Name = "btnSquareMode";
            this.btnSquareMode.Size = new System.Drawing.Size(62, 57);
            this.btnSquareMode.TabIndex = 10;
            this.btnSquareMode.Text = "Square";
            this.btnSquareMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSquareMode.UseVisualStyleBackColor = true;
            this.btnSquareMode.Click += new System.EventHandler(this.BtnSquareMode_Click);
            // 
            // lblSelRect
            // 
            this.lblSelRect.Font = new System.Drawing.Font("Ricty Diminished", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSelRect.Location = new System.Drawing.Point(571, 515);
            this.lblSelRect.Name = "lblSelRect";
            this.lblSelRect.Size = new System.Drawing.Size(179, 19);
            this.lblSelRect.TabIndex = 11;
            this.lblSelRect.Text = "(X, Y, Width, Height)";
            this.lblSelRect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCircleMode
            // 
            this.btnCircleMode.Font = new System.Drawing.Font("Ricty Diminished", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCircleMode.Image = ((System.Drawing.Image)(resources.GetObject("btnCircleMode.Image")));
            this.btnCircleMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCircleMode.Location = new System.Drawing.Point(80, 11);
            this.btnCircleMode.Name = "btnCircleMode";
            this.btnCircleMode.Size = new System.Drawing.Size(62, 57);
            this.btnCircleMode.TabIndex = 12;
            this.btnCircleMode.Text = "Circle";
            this.btnCircleMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircleMode.UseVisualStyleBackColor = true;
            this.btnCircleMode.Click += new System.EventHandler(this.BtnCircleMode_Click);
            // 
            // btnOpBack
            // 
            this.btnOpBack.Enabled = false;
            this.btnOpBack.Font = new System.Drawing.Font("Ricty Diminished", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpBack.Image = ((System.Drawing.Image)(resources.GetObject("btnOpBack.Image")));
            this.btnOpBack.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpBack.Location = new System.Drawing.Point(80, 75);
            this.btnOpBack.Name = "btnOpBack";
            this.btnOpBack.Size = new System.Drawing.Size(62, 57);
            this.btnOpBack.TabIndex = 13;
            this.btnOpBack.Text = "back";
            this.btnOpBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpBack.UseVisualStyleBackColor = true;
            this.btnOpBack.Click += new System.EventHandler(this.BtnOpBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnOpBack);
            this.Controls.Add(this.btnCircleMode);
            this.Controls.Add(this.lblSelRect);
            this.Controls.Add(this.btnSquareMode);
            this.Controls.Add(this.pnlThicknessList);
            this.Controls.Add(this.pnlColorList);
            this.Controls.Add(this.btnPenMode);
            this.Controls.Add(this.pbxMain);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.pnlColorList.ResumeLayout(false);
            this.pnlThicknessList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.Button btnPenMode;
        private System.Windows.Forms.Panel pnlColorList;
        private System.Windows.Forms.Panel pnlColor7;
        private System.Windows.Forms.Panel pnlColor6;
        private System.Windows.Forms.Panel pnlColor5;
        private System.Windows.Forms.Panel pnlColor4;
        private System.Windows.Forms.Panel pnlColor3;
        private System.Windows.Forms.Panel pnlColor2;
        private System.Windows.Forms.Panel pnlColor1;
        private System.Windows.Forms.Panel pnlColor0;
        private System.Windows.Forms.Panel pnlSelColor;
        private System.Windows.Forms.Panel pnlThicknessList;
        private System.Windows.Forms.Button btnSquareMode;
        private System.Windows.Forms.Label lblSelRect;
        private System.Windows.Forms.Label lblThick1;
        private System.Windows.Forms.Label lblThick0;
        private System.Windows.Forms.Label lblThick4;
        private System.Windows.Forms.Label lblThick3;
        private System.Windows.Forms.Label lblThick2;
        private System.Windows.Forms.Button btnCircleMode;
        private System.Windows.Forms.Button btnOpBack;
    }
}

