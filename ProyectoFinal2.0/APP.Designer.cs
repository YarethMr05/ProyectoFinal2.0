namespace ProyectoFinal2._0
{
    partial class APP
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APP));
            pictureBox1 = new PictureBox();
            lblUsuarioFormPrincipal = new Label();
            imageList1 = new ImageList(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialTabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.acceso;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblUsuarioFormPrincipal
            // 
            lblUsuarioFormPrincipal.AutoSize = true;
            lblUsuarioFormPrincipal.BackColor = Color.Transparent;
            lblUsuarioFormPrincipal.Font = new Font("Kozuka Gothic Pro B", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioFormPrincipal.ForeColor = Color.White;
            lblUsuarioFormPrincipal.Location = new Point(46, 22);
            lblUsuarioFormPrincipal.Name = "lblUsuarioFormPrincipal";
            lblUsuarioFormPrincipal.Size = new Size(93, 27);
            lblUsuarioFormPrincipal.TabIndex = 3;
            lblUsuarioFormPrincipal.Text = "USUARIO";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cpu.png");
            imageList1.Images.SetKeyName(1, "fuente-de-alimentacion.png");
            imageList1.Images.SetKeyName(2, "mineria-gpu.png");
            imageList1.Images.SetKeyName(3, "procesador.png");
            imageList1.Images.SetKeyName(4, "ssd.png");
            imageList1.Images.SetKeyName(5, "torre-de-la-cpu.png");
            imageList1.Images.SetKeyName(6, "pagina-de-inicio (1).png");
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Controls.Add(tabPage7);
            materialTabControl1.Controls.Add(tabPage8);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(928, 472);
            materialTabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.ImageKey = "pagina-de-inicio (1).png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(920, 429);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "INICIO";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "torre-de-la-cpu.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(920, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CASE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.ImageKey = "procesador.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(920, 429);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "CPU";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.ImageKey = "mineria-gpu.png";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(920, 429);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "GPU";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.ImageKey = "cpu.png";
            tabPage5.Location = new Point(4, 39);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(920, 429);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "RAM";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.ImageKey = "ssd.png";
            tabPage6.Location = new Point(4, 39);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(920, 429);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "SSD";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.ImageKey = "fuente-de-alimentacion.png";
            tabPage7.Location = new Point(4, 39);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(920, 429);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "FUENTE DE PODER";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 39);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(920, 429);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "PERIFERICO";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblUsuarioFormPrincipal);
            panel1.Location = new Point(60, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 54);
            panel1.TabIndex = 0;
            // 
            // APP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 539);
            Controls.Add(panel1);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "APP";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialTabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblUsuarioFormPrincipal;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Panel panel1;
    }
}