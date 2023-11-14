
namespace TP_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.registrate = new System.Windows.Forms.Button();
            this.fastBurger = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Button();
            this.AboutUs = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.Conctacanos = new System.Windows.Forms.Button();
            this.iniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrate
            // 
            this.registrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(118)))));
            this.registrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrate.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrate.ForeColor = System.Drawing.Color.White;
            this.registrate.Location = new System.Drawing.Point(82, 427);
            this.registrate.Name = "registrate";
            this.registrate.Size = new System.Drawing.Size(147, 55);
            this.registrate.TabIndex = 0;
            this.registrate.Text = "Registrate";
            this.registrate.UseVisualStyleBackColor = false;
            this.registrate.Click += new System.EventHandler(this.button1_Click);
            // 
            // fastBurger
            // 
            this.fastBurger.BackColor = System.Drawing.Color.Black;
            this.fastBurger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fastBurger.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastBurger.ForeColor = System.Drawing.Color.White;
            this.fastBurger.Location = new System.Drawing.Point(47, 170);
            this.fastBurger.Multiline = true;
            this.fastBurger.Name = "fastBurger";
            this.fastBurger.Size = new System.Drawing.Size(373, 216);
            this.fastBurger.TabIndex = 1;
            this.fastBurger.Text = "Fast\r\nBurger";
            this.fastBurger.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home.ForeColor = System.Drawing.Color.Transparent;
            this.Home.Location = new System.Drawing.Point(56, 27);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(128, 50);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.button2_Click);
            // 
            // AboutUs
            // 
            this.AboutUs.BackColor = System.Drawing.Color.Transparent;
            this.AboutUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutUs.BackgroundImage")));
            this.AboutUs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AboutUs.FlatAppearance.BorderSize = 0;
            this.AboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.AboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUs.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AboutUs.ForeColor = System.Drawing.Color.Transparent;
            this.AboutUs.Location = new System.Drawing.Point(179, 27);
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.AboutUs.Size = new System.Drawing.Size(187, 50);
            this.AboutUs.TabIndex = 3;
            this.AboutUs.Text = "Sobre Nosotros";
            this.AboutUs.UseVisualStyleBackColor = false;
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu.BackgroundImage")));
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Menu.ForeColor = System.Drawing.Color.Transparent;
            this.Menu.Location = new System.Drawing.Point(361, 27);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Menu.Size = new System.Drawing.Size(124, 50);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menú";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Conctacanos
            // 
            this.Conctacanos.BackColor = System.Drawing.Color.Transparent;
            this.Conctacanos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Conctacanos.BackgroundImage")));
            this.Conctacanos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Conctacanos.FlatAppearance.BorderSize = 0;
            this.Conctacanos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Conctacanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conctacanos.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Conctacanos.ForeColor = System.Drawing.Color.Transparent;
            this.Conctacanos.Location = new System.Drawing.Point(479, 27);
            this.Conctacanos.Name = "Conctacanos";
            this.Conctacanos.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Conctacanos.Size = new System.Drawing.Size(162, 50);
            this.Conctacanos.TabIndex = 5;
            this.Conctacanos.Text = "Contáctanos";
            this.Conctacanos.UseVisualStyleBackColor = false;
            this.Conctacanos.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // iniciarSesion
            // 
            this.iniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(118)))));
            this.iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciarSesion.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.iniciarSesion.Location = new System.Drawing.Point(243, 427);
            this.iniciarSesion.Name = "iniciarSesion";
            this.iniciarSesion.Size = new System.Drawing.Size(150, 55);
            this.iniciarSesion.TabIndex = 6;
            this.iniciarSesion.Text = "Iniciar Sesión";
            this.iniciarSesion.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 683);
            this.Controls.Add(this.iniciarSesion);
            this.Controls.Add(this.Conctacanos);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.AboutUs);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.fastBurger);
            this.Controls.Add(this.registrate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrate;
        private System.Windows.Forms.TextBox fastBurger;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button AboutUs;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Conctacanos;
        private System.Windows.Forms.Button iniciarSesion;
    }
}

