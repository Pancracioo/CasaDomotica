namespace CasaDomotica
{
    partial class Main
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.topMain = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnOtros = new FontAwesome.Sharp.IconButton();
            this.btnAscensor = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnLuces = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.9D;
            this.guna2DragControl1.TargetControl = this.topMain;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // topMain
            // 
            this.topMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topMain.Location = new System.Drawing.Point(0, 59);
            this.topMain.Margin = new System.Windows.Forms.Padding(4);
            this.topMain.Name = "topMain";
            this.topMain.Size = new System.Drawing.Size(1280, 661);
            this.topMain.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.SlateGray;
            this.guna2GradientPanel1.Controls.Add(this.btnMinimizar);
            this.guna2GradientPanel1.Controls.Add(this.btnOtros);
            this.guna2GradientPanel1.Controls.Add(this.btnAscensor);
            this.guna2GradientPanel1.Controls.Add(this.iconButton5);
            this.guna2GradientPanel1.Controls.Add(this.iconButton4);
            this.guna2GradientPanel1.Controls.Add(this.btnLuces);
            this.guna2GradientPanel1.Controls.Add(this.btnMaximizar);
            this.guna2GradientPanel1.Controls.Add(this.btnCerrar);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1280, 59);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 42;
            this.btnMinimizar.Location = new System.Drawing.Point(962, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(109, 59);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnOtros
            // 
            this.btnOtros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOtros.FlatAppearance.BorderSize = 0;
            this.btnOtros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnOtros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtros.ForeColor = System.Drawing.Color.White;
            this.btnOtros.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.btnOtros.IconColor = System.Drawing.Color.White;
            this.btnOtros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOtros.IconSize = 40;
            this.btnOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtros.Location = new System.Drawing.Point(720, 0);
            this.btnOtros.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(180, 59);
            this.btnOtros.TabIndex = 7;
            this.btnOtros.Text = "Otros:";
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // btnAscensor
            // 
            this.btnAscensor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAscensor.FlatAppearance.BorderSize = 0;
            this.btnAscensor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnAscensor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAscensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscensor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscensor.ForeColor = System.Drawing.Color.White;
            this.btnAscensor.IconChar = FontAwesome.Sharp.IconChar.Elevator;
            this.btnAscensor.IconColor = System.Drawing.Color.White;
            this.btnAscensor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAscensor.IconSize = 40;
            this.btnAscensor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAscensor.Location = new System.Drawing.Point(540, 0);
            this.btnAscensor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAscensor.Name = "btnAscensor";
            this.btnAscensor.Size = new System.Drawing.Size(180, 59);
            this.btnAscensor.TabIndex = 6;
            this.btnAscensor.Text = "Ascensor";
            this.btnAscensor.UseVisualStyleBackColor = true;
            this.btnAscensor.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 40;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(360, 0);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(180, 59);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Seguridad";
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(180, 0);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(180, 59);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Puertas";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnLuces
            // 
            this.btnLuces.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuces.FlatAppearance.BorderSize = 0;
            this.btnLuces.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray;
            this.btnLuces.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLuces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuces.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuces.ForeColor = System.Drawing.Color.White;
            this.btnLuces.IconChar = FontAwesome.Sharp.IconChar.Medapps;
            this.btnLuces.IconColor = System.Drawing.Color.White;
            this.btnLuces.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuces.IconSize = 40;
            this.btnLuces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuces.Location = new System.Drawing.Point(0, 0);
            this.btnLuces.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuces.Name = "btnLuces";
            this.btnLuces.Size = new System.Drawing.Size(180, 59);
            this.btnLuces.TabIndex = 3;
            this.btnLuces.Text = "Luces";
            this.btnLuces.UseVisualStyleBackColor = true;
            this.btnLuces.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 42;
            this.btnMaximizar.Location = new System.Drawing.Point(1071, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(109, 59);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 42;
            this.btnCerrar.Location = new System.Drawing.Point(1180, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 59);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.9D;
            this.guna2DragControl2.TargetControl = this.guna2GradientPanel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.topMain);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel topMain;
        private FontAwesome.Sharp.IconButton btnLuces;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnAscensor;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton btnOtros;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}