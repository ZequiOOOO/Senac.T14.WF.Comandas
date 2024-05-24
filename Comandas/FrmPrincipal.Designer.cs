namespace Comandas
{
    partial class FrmPrincipal
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
            airForm1 = new ReaLTaiizor.Forms.AirForm();
            dungeonForm1 = new ReaLTaiizor.Forms.DungeonForm();
            GpxPricipal = new ReaLTaiizor.Controls.CrownGroupBox();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnPedido = new ReaLTaiizor.Controls.MetroButton();
            btnUsuários = new ReaLTaiizor.Controls.MetroButton();
            airForm1.SuspendLayout();
            dungeonForm1.SuspendLayout();
            GpxPricipal.SuspendLayout();
            SuspendLayout();
            // 
            // airForm1
            // 
            airForm1.BackColor = Color.FromArgb(244, 241, 243);
            airForm1.BorderStyle = FormBorderStyle.None;
            airForm1.Controls.Add(dungeonForm1);
            airForm1.Customization = "AAAA/1paWv9ycnL/";
            airForm1.Dock = DockStyle.Fill;
            airForm1.Font = new Font("Segoe UI", 9F);
            airForm1.Image = null;
            airForm1.Location = new Point(0, 0);
            airForm1.MinimumSize = new Size(261, 65);
            airForm1.Movable = true;
            airForm1.Name = "airForm1";
            airForm1.NoRounding = false;
            airForm1.Sizable = true;
            airForm1.Size = new Size(800, 450);
            airForm1.SmartBounds = true;
            airForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            airForm1.TabIndex = 0;
            airForm1.Text = "airForm1";
            airForm1.TransparencyKey = Color.Fuchsia;
            airForm1.Transparent = false;
            // 
            // dungeonForm1
            // 
            dungeonForm1.BackColor = Color.FromArgb(244, 241, 243);
            dungeonForm1.BorderColor = Color.FromArgb(38, 38, 38);
            dungeonForm1.Controls.Add(GpxPricipal);
            dungeonForm1.Dock = DockStyle.Fill;
            dungeonForm1.FillEdgeColorA = Color.FromArgb(69, 68, 63);
            dungeonForm1.FillEdgeColorB = Color.FromArgb(69, 68, 63);
            dungeonForm1.Font = new Font("Segoe UI", 9F);
            dungeonForm1.FooterEdgeColor = Color.FromArgb(69, 68, 63);
            dungeonForm1.ForeColor = Color.FromArgb(223, 219, 210);
            dungeonForm1.HeaderEdgeColorA = Color.FromArgb(87, 85, 77);
            dungeonForm1.HeaderEdgeColorB = Color.FromArgb(69, 68, 63);
            dungeonForm1.Location = new Point(0, 0);
            dungeonForm1.Name = "dungeonForm1";
            dungeonForm1.Padding = new Padding(20, 56, 20, 16);
            dungeonForm1.RoundCorners = true;
            dungeonForm1.Sizable = true;
            dungeonForm1.Size = new Size(800, 450);
            dungeonForm1.SmartBounds = true;
            dungeonForm1.StartPosition = FormStartPosition.CenterScreen;
            dungeonForm1.TabIndex = 0;
            dungeonForm1.Text = "dungeonForm1";
            dungeonForm1.TitleColor = Color.FromArgb(223, 219, 210);
            // 
            // GpxPricipal
            // 
            GpxPricipal.BorderColor = Color.FromArgb(51, 51, 51);
            GpxPricipal.Controls.Add(btnUsuários);
            GpxPricipal.Controls.Add(btnPedido);
            GpxPricipal.Controls.Add(btnComanda);
            GpxPricipal.Controls.Add(btnCardapio);
            GpxPricipal.Location = new Point(52, 113);
            GpxPricipal.Name = "GpxPricipal";
            GpxPricipal.Size = new Size(693, 299);
            GpxPricipal.TabIndex = 0;
            GpxPricipal.TabStop = false;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.Gray;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.ForeColor = Color.White;
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.Silver;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(54, 102);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnCardapio.NormalColor = Color.LightGray;
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.PowderBlue;
            btnCardapio.Size = new Size(117, 97);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += this.metroButton1_Click;
            // 
            // btnComanda
            // 
            btnComanda.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnComanda.DisabledForeColor = Color.Gray;
            btnComanda.Font = new Font("Microsoft Sans Serif", 10F);
            btnComanda.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverColor = Color.FromArgb(95, 207, 255);
            btnComanda.HoverTextColor = Color.White;
            btnComanda.IsDerivedStyle = true;
            btnComanda.Location = new Point(208, 102);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(120, 97);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.Click += this.metroButton2_Click;
            // 
            // btnPedido
            // 
            btnPedido.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedido.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedido.DisabledForeColor = Color.Gray;
            btnPedido.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedido.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedido.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedido.HoverTextColor = Color.White;
            btnPedido.IsDerivedStyle = true;
            btnPedido.Location = new Point(366, 102);
            btnPedido.Name = "btnPedido";
            btnPedido.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedido.NormalColor = Color.FromArgb(65, 177, 225);
            btnPedido.NormalTextColor = Color.White;
            btnPedido.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedido.PressColor = Color.FromArgb(35, 147, 195);
            btnPedido.PressTextColor = Color.White;
            btnPedido.Size = new Size(120, 97);
            btnPedido.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedido.StyleManager = null;
            btnPedido.TabIndex = 2;
            btnPedido.Text = "Pedido Cozinha";
            btnPedido.ThemeAuthor = "Taiizor";
            btnPedido.ThemeName = "MetroLight";
            // 
            // btnUsuários
            // 
            btnUsuários.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuários.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuários.DisabledForeColor = Color.Gray;
            btnUsuários.Font = new Font("Microsoft Sans Serif", 10F);
            btnUsuários.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnUsuários.HoverColor = Color.FromArgb(95, 207, 255);
            btnUsuários.HoverTextColor = Color.White;
            btnUsuários.IsDerivedStyle = true;
            btnUsuários.Location = new Point(521, 102);
            btnUsuários.Name = "btnUsuários";
            btnUsuários.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuários.NormalColor = Color.FromArgb(65, 177, 225);
            btnUsuários.NormalTextColor = Color.White;
            btnUsuários.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuários.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuários.PressTextColor = Color.White;
            btnUsuários.Size = new Size(120, 97);
            btnUsuários.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnUsuários.StyleManager = null;
            btnUsuários.TabIndex = 3;
            btnUsuários.Text = "Usuários";
            btnUsuários.ThemeAuthor = "Taiizor";
            btnUsuários.ThemeName = "MetroLight";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(airForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 65);
            Name = "FrmPrincipal";
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            airForm1.ResumeLayout(false);
            dungeonForm1.ResumeLayout(false);
            GpxPricipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Forms.DungeonForm dungeonForm1;
        private ReaLTaiizor.Controls.CrownGroupBox GpxPricipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuários;
        private ReaLTaiizor.Controls.MetroButton btnPedido;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
    }
}
