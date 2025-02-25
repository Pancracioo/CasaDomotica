namespace CasaDomotica.Menu
{
    partial class frmAscensor
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
            this.tilebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSubir = new FontAwesome.Sharp.IconButton();
            this.btnBajar = new FontAwesome.Sharp.IconButton();
            this.tilebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilebar
            // 
            this.tilebar.BackColor = System.Drawing.Color.SlateGray;
            this.tilebar.Controls.Add(this.label12);
            this.tilebar.Controls.Add(this.btnCerrar);
            this.tilebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tilebar.Location = new System.Drawing.Point(0, 0);
            this.tilebar.Name = "tilebar";
            this.tilebar.Size = new System.Drawing.Size(264, 50);
            this.tilebar.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ascensor";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 52;
            this.btnCerrar.Location = new System.Drawing.Point(189, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 50);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.9D;
            this.guna2DragControl1.TargetControl = this.tilebar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 18;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnSubir
            // 
            this.btnSubir.BackColor = System.Drawing.Color.Transparent;
            this.btnSubir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubir.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.btnSubir.IconColor = System.Drawing.Color.Red;
            this.btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubir.IconSize = 72;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubir.Location = new System.Drawing.Point(0, 50);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(264, 111);
            this.btnSubir.TabIndex = 95;
            this.btnSubir.UseVisualStyleBackColor = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.BackColor = System.Drawing.Color.Transparent;
            this.btnBajar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBajar.FlatAppearance.BorderSize = 0;
            this.btnBajar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBajar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBajar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBajar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown;
            this.btnBajar.IconColor = System.Drawing.Color.Red;
            this.btnBajar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBajar.IconSize = 72;
            this.btnBajar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBajar.Location = new System.Drawing.Point(0, 169);
            this.btnBajar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(264, 126);
            this.btnBajar.TabIndex = 96;
            this.btnBajar.UseVisualStyleBackColor = false;
            this.btnBajar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // frmAscensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 295);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.tilebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAscensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAscensor";
            this.tilebar.ResumeLayout(false);
            this.tilebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel tilebar;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private FontAwesome.Sharp.IconButton btnSubir;
        private FontAwesome.Sharp.IconButton btnBajar;
    }
}