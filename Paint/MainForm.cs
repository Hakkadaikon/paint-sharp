using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class MainForm : Form
    {
        private enum eDrawMode
        {
            Pen,
            Circle,
            Square,
            EndOfIndex
        };

        private enum eDrawSize
        {
            px1 ,
            px2 ,
            px4 ,
            px8 ,
            px16,
            EndOfIndex
        };

        private eDrawMode drawMode;
        private eDrawSize drawSize;

        private int       bmpNo;
        private Bitmap[]  pbxBmp;
        private Graphics  graphics;

        private Pen       pen;
        private Point     prevPenPoint;

        private Point     startSelPoint;

        private const int COLOR_NUM = 8;
        private Color     selColor;
        private Panel[]   pnlColor;
        private Label[]   lblThick;
        private Button[]  btnDrawMode;

        private bool      isSelect;

        Rectangle drawRect;

        #region Initialize

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeParam()
        {
            bmpNo = 0;
            pbxBmp = new Bitmap[2];
            for (int i = 0; i < 2; i++)
            {
                pbxBmp[i] = new Bitmap(pbxMain.Width, pbxMain.Height);
            }

            btnDrawMode = new Button[(int)eDrawMode.EndOfIndex];
            btnDrawMode[0] = btnPenMode;
            btnDrawMode[1] = btnCircleMode;
            btnDrawMode[2] = btnSquareMode;

            selColor = Color.Black;
            pnlSelColor.BackColor = selColor;
            drawSize = eDrawSize.px1;
            lblSelRect.Visible = false;

            InitializeDrawMode(eDrawMode.Pen);
            isSelect = false;
        }

        #endregion

        #region Canvas Utility
        private void InitializeCanvas()
        {
            if(graphics != null)
            {
                graphics.Dispose();
            }

            pbxMain.Image = pbxBmp[bmpNo];
            graphics = Graphics.FromImage(pbxMain.Image);
        }

        private void FripCanvas()
        {
            bmpNo = (bmpNo == 0) ? 1 : 0;
            pbxMain.Image = pbxBmp[bmpNo];
            graphics = Graphics.FromImage(pbxMain.Image);
        }

        private void CopyCanvas()
        {
            int bkSide = (bmpNo == 0) ? 1 : 0;
            pbxBmp[bkSide].Dispose();
            pbxBmp[bkSide] = (Bitmap)pbxBmp[bmpNo].Clone();
        }

        private void DisposeCanvas()
        {
            if(pen != null)
            {
                pen.Dispose();
            }

            graphics.Dispose();
        }

        private void InitializeDrawMode(eDrawMode newMode)
        {
            drawMode = newMode;

            for (int i = 0; i < (int)eDrawMode.EndOfIndex; i++)
            {
                btnDrawMode[i].BackColor = 
                    ((eDrawMode)i == drawMode) ? Color.Aqua : SystemColors.Control;
            }
            
            InitializePen();
        }
        #endregion

        #region Color Utility
        private void InitializeColor()
        {
            Color[] setColor = new Color[COLOR_NUM]
            {
                Color.White,
                Color.Black,
                Color.Red,
                Color.Blue,
                Color.Yellow,
                Color.Green,
                Color.Pink,
                Color.Brown
            };

            pnlColor = new Panel[COLOR_NUM];
            pnlColor[0] = pnlColor0;
            pnlColor[1] = pnlColor1;
            pnlColor[2] = pnlColor2;
            pnlColor[3] = pnlColor3;
            pnlColor[4] = pnlColor4;
            pnlColor[5] = pnlColor5;
            pnlColor[6] = pnlColor6;
            pnlColor[7] = pnlColor7;

            for(int i = 0; i < COLOR_NUM; i++)
            {
                pnlColor[i].BackColor = setColor[i];
                pnlColor[i].Click += PnlColor_Click;
            }
        }

        private void PnlColor_Click(object sender, EventArgs e)
        {
            Panel pnlSel = (Panel)sender;
            selColor = pnlSel.BackColor;
            pnlSelColor.BackColor = selColor;

            InitializeDrawMode(drawMode);
        }
        #endregion

        #region Thickness Utility
        private void InitializeThickness()
        {
            lblThick = new Label[(int)eDrawSize.EndOfIndex];
            lblThick[0] = lblThick0;
            lblThick[1] = lblThick1;
            lblThick[2] = lblThick2;
            lblThick[3] = lblThick3;
            lblThick[4] = lblThick4;

            for (int i = 0; i < (int)eDrawSize.EndOfIndex; i++)
            {
                lblThick[i].Tag   = (eDrawMode)i;
                lblThick[i].Text  = ((eDrawSize)i).ToString();
                lblThick[i].Click += lblThick_Click;
            }

            lblThick[0].BackColor = Color.Aqua;
        }

        private void lblThick_Click(object sender, EventArgs e)
        {
            Label lblSelThick = (Label)sender;

            for (int i = 0; i < (int)eDrawSize.EndOfIndex; i++)
            {
                lblThick[i].BackColor = SystemColors.Control;
            }

            lblSelThick.BackColor = Color.Aqua;
            drawSize = (eDrawSize)lblSelThick.Tag;
            InitializePen();
        }
        #endregion

        #region Other Utility
        private void SetStartPos(int clickX, int clickY)
        {
            startSelPoint.X = clickX;
            startSelPoint.Y = clickY;
        }

        private void SetDrawRectPoint(int clickX, int clickY)
        {
            drawRect.X = (clickX > startSelPoint.X) ? startSelPoint.X : clickX;
            drawRect.Y = (clickY > startSelPoint.Y) ? startSelPoint.Y : clickY;

            drawRect.Width = (clickX > startSelPoint.X) ?
                (clickX - startSelPoint.X) :
                (startSelPoint.X - clickX);

            drawRect.Height = (clickY > startSelPoint.Y) ?
                (clickY - startSelPoint.Y) :
                (startSelPoint.Y - clickY);

            lblSelRect.Text = "(" +
                drawRect.X     + ", " + 
                drawRect.Y     + ", " +
                drawRect.Width + ", " + 
                drawRect.Height
                + ")";
        }
        #endregion

        #region Pen Utility
        private int getRealDrawSize(eDrawSize drawSize)
        {
            switch (drawSize)
            {
                case eDrawSize.px1:
                    return 1;

                case eDrawSize.px2:
                    return 2;

                case eDrawSize.px4:
                    return 4;

                case eDrawSize.px8:
                    return 8;

                case eDrawSize.px16:
                    return 16;

                default:
                    return 1;
            }
        }

        private void InitializePen()
        {
            DisposePen();

            int realDrawSize = getRealDrawSize(drawSize);

            pen = new Pen(selColor, realDrawSize);
        }

        private void DisposePen()
        {
            if (pen != null)
            {
                pen.Dispose();
            }
        }

        private int GetPenPoint(int clickPoint)
        {
            int drawPoint = clickPoint - (int)((double)getRealDrawSize(drawSize) / 2.0);

            return (drawPoint < 0) ? 0 : drawPoint;
        }

        private void SetPenSize(int clickX, int clickY)
        {
            drawRect.X = GetPenPoint(clickX);
            drawRect.Y = GetPenPoint(clickY);

            drawRect.Width  = getRealDrawSize(drawSize);
            drawRect.Height = getRealDrawSize(drawSize);
        }

        private void SavePrevPenPoint()
        {
            prevPenPoint.X = drawRect.X;
            prevPenPoint.Y = drawRect.Y;
        }

        private void DrawLine(Point pt0, Point pt1)
        {
            int x0;
            int y0;
            int x1;
            int y1;

            int dx;
            int dy;
            int sx;
            int sy;

            int err;

            x0 = pt1.X;
            y0 = pt1.Y;
            x1 = pt1.X;
            y1 = pt1.Y;

            //Bresenham

            dx  = Math.Abs(x1 - x0);
            dy  = Math.Abs(y1 - y0);
            sx  = (x0 < x1) ? 1 : 0;
            sy  = (y0 < y1) ? 1 : 0;

            err = (dx >= dy) ? 
                (2 * dy - dx) : (2 * dx - dy);

            while (true)
            {
                graphics.DrawEllipse(pen, x0, y0, drawRect.Width, drawRect.Height);

                if(x0 == x1 && y0 == y1)
                {
                    break;
                }

                if(dx >= dy)
                {
                    x0  += sx;
                    err += 2 * dy;
                    if(err >= 0)
                    {
                        y0  += sy;
                        err -= 2 * dx;
                    }
                }
                else
                {
                    y0  += sy;
                    err += 2 * dx;
                    if (err >= 0)
                    {
                        x0  += sx;
                        err -= 2 * dy;
                    }
                }
            }

            pbxMain.Refresh();
        }
        #endregion

        #region Shape Utility

        private void DrawShape(int clickX, int clickY)
        {
            if(graphics != null)
            {
                graphics.Dispose();
            }

            SetDrawRectPoint(clickX, clickY);

            Bitmap drawBmp = (Bitmap)pbxBmp[bmpNo].Clone();

            graphics = Graphics.FromImage(drawBmp);

            switch(drawMode)
            {
                case eDrawMode.Square:
                    graphics.DrawRectangle(pen, drawRect);
                    break;

                case eDrawMode.Circle:
                    graphics.DrawEllipse(pen, drawRect);
                    break;
            }

            graphics.Dispose();

            pbxMain.Image = drawBmp;
        }

        #endregion

        #region Form events
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeParam();
            InitializeCanvas();
            InitializeColor();
            InitializeThickness();

            timerDraw.Enabled = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeCanvas();
        }
        #endregion

        #region PictureBox Events

        private void PbxMain_MouseDown(object sender, MouseEventArgs e)
        {
            isSelect = true;
            CopyCanvas();

            switch (drawMode)
            {
                case eDrawMode.Pen:
                    SetPenSize(e.X, e.Y);
                    graphics.DrawEllipse(pen, drawRect);
                    SavePrevPenPoint();
                    break;

                case eDrawMode.Circle:
                case eDrawMode.Square:
                    this.Cursor = Cursors.Cross;
                    SetStartPos(e.X, e.Y);
                    lblSelRect.Visible = true;
                    break;

                default:
                    break;
            }

            pbxMain.Refresh();
        }

        private void PbxMain_MouseUp(object sender, MouseEventArgs e)
        {
            isSelect = false;
            this.Cursor = Cursors.Arrow;

            switch (drawMode)
            {
                case eDrawMode.Pen:
                    break;

                case eDrawMode.Circle:
                case eDrawMode.Square:
                    pbxBmp[bmpNo] = (Bitmap)pbxMain.Image.Clone();
                    InitializeCanvas();
                    lblSelRect.Visible = false;
                    break;

                default:
                    break;
            }

            btnOpBack.Enabled = true;
        }

        private void PbxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(!isSelect)
            {
                return;
            }

            switch (drawMode)
            {
                case eDrawMode.Pen:
                    SetPenSize(e.X, e.Y);

                    //graphics.DrawLine(pen, prevPenPoint, drawRect.Location);
                    DrawLine(prevPenPoint, drawRect.Location);
                    break;

                case eDrawMode.Circle:
                case eDrawMode.Square:
                    DrawShape(e.X, e.Y);
                    break;

                default:
                    break;
            }
        }

        private void PbxMain_MouseLeave(object sender, EventArgs e)
        {
            isSelect = false;
            InitializeCanvas();
        }

        private void TimerDraw_Tick(object sender, EventArgs e)
        {
            switch(drawMode)
            {
                case eDrawMode.Pen:
                    //pbxMain.Refresh();
                    break;
            }
        }

        #endregion

        #region Button Events

        private void BtnPenMode_Click(object sender, EventArgs e)
        {
            InitializeDrawMode(eDrawMode.Pen);
        }

        private void BtnSquareMode_Click(object sender, EventArgs e)
        {
            InitializeDrawMode(eDrawMode.Square);
        }

        private void BtnCircleMode_Click(object sender, EventArgs e)
        {
            InitializeDrawMode(eDrawMode.Circle);
        }

        private void BtnOpBack_Click(object sender, EventArgs e)
        {
            FripCanvas();
            CopyCanvas();
            btnOpBack.Enabled = false;
        }
        #endregion

    }
}
