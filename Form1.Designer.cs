namespace _62024_Antoni_Piwowarski_WinGraphics2D
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labTransformationsList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBoxTranslationX = new System.Windows.Forms.TextBox();
            this.txtBoxRotation = new System.Windows.Forms.TextBox();
            this.txtBoxRotationX = new System.Windows.Forms.TextBox();
            this.txtBoxScalingX = new System.Windows.Forms.TextBox();
            this.txtBoxTranslationY = new System.Windows.Forms.TextBox();
            this.txtBoxRotationY = new System.Windows.Forms.TextBox();
            this.txtBoxScalingY = new System.Windows.Forms.TextBox();
            this.txtBoxRotationAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxShearingY = new System.Windows.Forms.TextBox();
            this.txtBoxShearingX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(209, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1296, 720);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Translation",
            "Rotation",
            "RotationAround(x0, y0)",
            "Scaling",
            "ReflectionX",
            "ReflectionY",
            "ShearingX",
            "ShearingY"});
            this.checkedListBox1.Location = new System.Drawing.Point(516, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(225, 196);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // labTransformationsList
            // 
            this.labTransformationsList.AutoSize = true;
            this.labTransformationsList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTransformationsList.Location = new System.Drawing.Point(12, 216);
            this.labTransformationsList.Name = "labTransformationsList";
            this.labTransformationsList.Size = new System.Drawing.Size(59, 22);
            this.labTransformationsList.TabIndex = 2;
            this.labTransformationsList.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(191, 720);
            this.dataGridView1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(136, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 39);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPolygon.Location = new System.Drawing.Point(40, 108);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(129, 55);
            this.btnPolygon.TabIndex = 5;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(993, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 51);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBoxTranslationX
            // 
            this.txtBoxTranslationX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTranslationX.Location = new System.Drawing.Point(747, 12);
            this.txtBoxTranslationX.Name = "txtBoxTranslationX";
            this.txtBoxTranslationX.Size = new System.Drawing.Size(36, 22);
            this.txtBoxTranslationX.TabIndex = 7;
            this.txtBoxTranslationX.Text = "50";
            this.txtBoxTranslationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxRotation
            // 
            this.txtBoxRotation.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxRotation.Location = new System.Drawing.Point(747, 38);
            this.txtBoxRotation.Name = "txtBoxRotation";
            this.txtBoxRotation.Size = new System.Drawing.Size(36, 22);
            this.txtBoxRotation.TabIndex = 8;
            this.txtBoxRotation.Text = "30";
            this.txtBoxRotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxRotationX
            // 
            this.txtBoxRotationX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxRotationX.Location = new System.Drawing.Point(747, 64);
            this.txtBoxRotationX.Name = "txtBoxRotationX";
            this.txtBoxRotationX.Size = new System.Drawing.Size(36, 22);
            this.txtBoxRotationX.TabIndex = 10;
            this.txtBoxRotationX.Text = "100";
            this.txtBoxRotationX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxScalingX
            // 
            this.txtBoxScalingX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxScalingX.Location = new System.Drawing.Point(747, 92);
            this.txtBoxScalingX.Name = "txtBoxScalingX";
            this.txtBoxScalingX.Size = new System.Drawing.Size(36, 22);
            this.txtBoxScalingX.TabIndex = 11;
            this.txtBoxScalingX.Text = "0,5";
            this.txtBoxScalingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxTranslationY
            // 
            this.txtBoxTranslationY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxTranslationY.Location = new System.Drawing.Point(789, 12);
            this.txtBoxTranslationY.Name = "txtBoxTranslationY";
            this.txtBoxTranslationY.Size = new System.Drawing.Size(36, 22);
            this.txtBoxTranslationY.TabIndex = 12;
            this.txtBoxTranslationY.Text = "30";
            this.txtBoxTranslationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxRotationY
            // 
            this.txtBoxRotationY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxRotationY.Location = new System.Drawing.Point(789, 64);
            this.txtBoxRotationY.Name = "txtBoxRotationY";
            this.txtBoxRotationY.Size = new System.Drawing.Size(36, 22);
            this.txtBoxRotationY.TabIndex = 13;
            this.txtBoxRotationY.Text = "90";
            this.txtBoxRotationY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxScalingY
            // 
            this.txtBoxScalingY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxScalingY.Location = new System.Drawing.Point(789, 92);
            this.txtBoxScalingY.Name = "txtBoxScalingY";
            this.txtBoxScalingY.Size = new System.Drawing.Size(36, 22);
            this.txtBoxScalingY.TabIndex = 14;
            this.txtBoxScalingY.Text = "0,5";
            this.txtBoxScalingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxRotationAngle
            // 
            this.txtBoxRotationAngle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxRotationAngle.Location = new System.Drawing.Point(831, 64);
            this.txtBoxRotationAngle.Name = "txtBoxRotationAngle";
            this.txtBoxRotationAngle.Size = new System.Drawing.Size(36, 22);
            this.txtBoxRotationAngle.TabIndex = 15;
            this.txtBoxRotationAngle.Text = "30";
            this.txtBoxRotationAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Polygon";
            // 
            // txtBoxShearingY
            // 
            this.txtBoxShearingY.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxShearingY.Location = new System.Drawing.Point(747, 186);
            this.txtBoxShearingY.Name = "txtBoxShearingY";
            this.txtBoxShearingY.Size = new System.Drawing.Size(36, 22);
            this.txtBoxShearingY.TabIndex = 18;
            this.txtBoxShearingY.Text = "1";
            this.txtBoxShearingY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxShearingX
            // 
            this.txtBoxShearingX.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxShearingX.Location = new System.Drawing.Point(747, 157);
            this.txtBoxShearingX.Name = "txtBoxShearingX";
            this.txtBoxShearingX.Size = new System.Drawing.Size(36, 22);
            this.txtBoxShearingX.TabIndex = 17;
            this.txtBoxShearingX.Text = "1";
            this.txtBoxShearingX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblY.Location = new System.Drawing.Point(1302, 129);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(24, 27);
            this.lblY.TabIndex = 37;
            this.lblY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblX.Location = new System.Drawing.Point(1245, 129);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(24, 27);
            this.lblX.TabIndex = 36;
            this.lblX.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(1244, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "X     Y";
            // 
            // btnResest
            // 
            this.btnResest.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResest.Location = new System.Drawing.Point(993, 129);
            this.btnResest.Name = "btnResest";
            this.btnResest.Size = new System.Drawing.Size(107, 51);
            this.btnResest.TabIndex = 38;
            this.btnResest.Text = "Reset";
            this.btnResest.UseVisualStyleBackColor = true;
            this.btnResest.Click += new System.EventHandler(this.btnResest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1517, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 962);
            this.Controls.Add(this.btnResest);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxShearingY);
            this.Controls.Add(this.txtBoxShearingX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRotationAngle);
            this.Controls.Add(this.txtBoxScalingY);
            this.Controls.Add(this.txtBoxRotationY);
            this.Controls.Add(this.txtBoxTranslationY);
            this.Controls.Add(this.txtBoxScalingX);
            this.Controls.Add(this.txtBoxRotationX);
            this.Controls.Add(this.txtBoxRotation);
            this.Controls.Add(this.txtBoxTranslationX);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labTransformationsList);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Antoni Piwowarski 62024";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labTransformationsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBoxTranslationX;
        private System.Windows.Forms.TextBox txtBoxRotation;
        private System.Windows.Forms.TextBox txtBoxRotationX;
        private System.Windows.Forms.TextBox txtBoxScalingX;
        private System.Windows.Forms.TextBox txtBoxTranslationY;
        private System.Windows.Forms.TextBox txtBoxRotationY;
        private System.Windows.Forms.TextBox txtBoxScalingY;
        private System.Windows.Forms.TextBox txtBoxRotationAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxShearingY;
        private System.Windows.Forms.TextBox txtBoxShearingX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

