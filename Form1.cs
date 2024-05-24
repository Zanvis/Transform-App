using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62024_Antoni_Piwowarski_WinGraphics2D
{
    public partial class Form1 : Form
    {
        int apvertexNo = 3;
        float[,] apvertices;
        bool appolygon = false;
        int apcounter;
        Graphics apgraphics;
        Pen appen = new Pen(Color.Black);
        
        List<string> apTransformations = new List<string>();
        public Form1()
        {
            InitializeComponent();
            appen.Width = 2;
            dataGridView1.ColumnCount = 5;
            for (int api = 0; api < dataGridView1.ColumnCount; api++)
            {
                dataGridView1.Columns[api].Width = 50;
            }
            dataGridView1.Columns[0].HeaderText = "x";
            dataGridView1.Columns[1].HeaderText = "y";
            dataGridView1.Columns[2].HeaderText = "z";
            apgraphics = pictureBox1.CreateGraphics();
            labTransformationsList.Text = "";
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int apindex = e.Index;
            switch (apindex)
            {
                case 0: // Translation
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("Translation");
                    else
                        apTransformations.Remove("Translation");
                    break;
                case 1: // Rotation around (0,0)
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("Rotation");
                    else
                        apTransformations.Remove("Rotation");
                    break;
                case 2: // Rotation around (x0,y0)
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("RotationAround(x0,y0)");
                    else
                        apTransformations.Remove("RotationAround(x0,y0)");
                    break;
                case 3: // Scaling
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("Scaling");
                    else
                        apTransformations.Remove("Scaling");
                    break;
                case 4: // ReflectionX
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("ReflectionX");
                    else
                        apTransformations.Remove("ReflectionX");
                    break;
                case 5: // ReflectionY
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("ReflectionY");
                    else
                        apTransformations.Remove("ReflectionY");
                    break;
                case 6: // ShearingX
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("ShearingX");
                    else
                        apTransformations.Remove("ShearingX");
                    break;
                case 7: // ShearingY
                    if (e.NewValue.ToString() == "Checked")
                        apTransformations.Add("ShearingY");
                    else
                        apTransformations.Remove("ShearingY");
                    break;
            }// end of switch
            labTransformationsList.Text = "transformations order: ";
            foreach (string apel in apTransformations)
            {
                labTransformationsList.Text += apel + ", ";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            apvertexNo = Convert.ToInt32(numericUpDown1.Value);
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            appolygon = true;
            btnPolygon.Enabled = false;
            apvertices = new float[apvertexNo, 3];
            apcounter = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (appolygon)
            {
                MouseEventArgs appoint = (MouseEventArgs)e;
                if (apcounter < apvertices.GetLength(0))
                {
                    float appointSize = 5.0f;
                    float appointX = appoint.X - (appointSize / 2);
                    float appointY = appoint.Y - (appointSize / 2);
                    if (apcounter < apvertices.GetLength(0) - 1)
                    {
                        apgraphics.FillEllipse(Brushes.Black, appointX, appointY, appointSize, appointSize);
                    }

                    apvertices[apcounter, 0] = appoint.X;
                    apvertices[apcounter, 1] = appoint.Y;
                    apvertices[apcounter, 2] = 1;
                    if (apcounter >= 1)
                        apgraphics.DrawLine(appen, apvertices[apcounter - 1, 0], apvertices[apcounter - 1, 1], apvertices[apcounter, 0], apvertices[apcounter, 1]);
                    apcounter++;
                    if (apcounter == apvertices.GetLength(0))
                    {
                        apgraphics.DrawLine(appen, apvertices[apcounter - 1, 0], apvertices[apcounter - 1, 1], apvertices[0, 0], apvertices[0, 1]);

                        RedrawShapeWithoutPoints();
                        Transformation2D.apdisplayArray(apvertices, dataGridView1);
                    }
                }
            }
        }

        private void RedrawShapeWithoutPoints()
        {
            apgraphics.Clear(pictureBox1.BackColor);

            for (int api = 1; api < apvertices.GetLength(0); api++)
            {
                apgraphics.DrawLine(appen, apvertices[api - 1, 0], apvertices[api - 1, 1], apvertices[api, 0], apvertices[api, 1]);
            }

            apgraphics.DrawLine(appen, apvertices[0, 0], apvertices[0, 1], apvertices[apvertices.GetLength(0) - 1, 0], apvertices[apvertices.GetLength(0) - 1, 1]);
        }

        private void drawPolygon()
        {
            for (int api = 1; api < apvertices.GetLength(0); api++)
            {
                apgraphics.DrawLine(appen, apvertices[api - 1, 0], apvertices[api - 1, 1], apvertices[api, 0], apvertices[api, 1]);
            }
            apgraphics.DrawLine(appen, apvertices[0, 0], apvertices[0, 1], apvertices[apvertices.GetLength(0) - 1, 0], apvertices[apvertices.GetLength(0) - 1, 1]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            float[,] aptransformMatrix;
            foreach (string apel in apTransformations)
            {
                switch (apel)
                {
                    case "Translation":
                        appen.Color = Color.Blue;
                        try
                        {
                            float aptx = Convert.ToSingle(txtBoxTranslationX.Text);
                            float apty = Convert.ToSingle(txtBoxTranslationY.Text);
                            aptransformMatrix = Transformation2D.apRightTranslationMatrix(aptx, apty);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                    case "Rotation":
                        appen.Color = Color.Red;
                        try
                        {
                            double apangle = Convert.ToDouble(txtBoxRotation.Text) * Math.PI / 180;
                            aptransformMatrix = Transformation2D.apRightRotationMatrix(apangle);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                    case "RotationAround(x0,y0)":
                        appen.Color = Color.Cyan;
                        try
                        {
                            float aptx1 = Convert.ToSingle(txtBoxRotationX.Text);
                            float apty1 = Convert.ToSingle(txtBoxRotationY.Text);
                            double apangle1 = Convert.ToDouble(txtBoxRotationAngle.Text) * Math.PI / 180;
                            aptransformMatrix = Transformation2D.apRightRotationAboutPointMatrix(aptx1, apty1, apangle1);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                    case "Scaling":
                        appen.Color = Color.Green;
                        try
                        {
                            float apsx = Convert.ToSingle(txtBoxScalingX.Text);
                            float apsy = Convert.ToSingle(txtBoxScalingY.Text);

                            aptransformMatrix = Transformation2D.apScalingMatrix(apsx, apsy);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                    case "ReflectionX":
                        appen.Color = Color.Magenta;
                        aptransformMatrix = Transformation2D.apReflectionXMatrix();
                        apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                        drawPolygon();
                        Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        break;

                    case "ReflectionY":
                        appen.Color = Color.Orange;
                        aptransformMatrix = Transformation2D.apReflectionYMatrix();
                        apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                        drawPolygon();
                        Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        break;
                    case "ShearingX":
                        appen.Color = Color.Purple;
                        try
                        {
                            float apsh_x = Convert.ToSingle(txtBoxShearingX.Text);
                            aptransformMatrix = Transformation2D.apShearingXMatrix(apsh_x);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                    case "ShearingY":
                        appen.Color = Color.Pink;
                        try
                        {
                            float apsh_y = Convert.ToSingle(txtBoxShearingY.Text);
                            aptransformMatrix = Transformation2D.apShearingYMatrix(apsh_y);
                            apvertices = Transformation2D.apMatrixMultiplication(apvertices, aptransformMatrix);
                            drawPolygon();
                            Transformation2D.apdisplayArray(apvertices, dataGridView1);
                        }
                        catch { }
                        break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void btnResest_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            if (pictureBox1.BackgroundImage != null)
            {
                pictureBox1.BackgroundImage.Dispose();
                pictureBox1.BackgroundImage = null;
            }
            pictureBox1.Invalidate();

            dataGridView1.Rows.Clear();
            apTransformations.Clear();
            apvertices = null;
            appolygon = false;
            apcounter = 0;
            numericUpDown1.Enabled = true;
            btnPolygon.Enabled = true;

            for (int api = 0; api < checkedListBox1.Items.Count; api++)
            {
                checkedListBox1.SetItemChecked(api, false);
            }

            appen.Color = Color.Black;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult apdialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apdialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
