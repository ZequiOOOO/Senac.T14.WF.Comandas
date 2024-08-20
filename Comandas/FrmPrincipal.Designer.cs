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
            gpxPrincipal = new GroupBox();
            btnUsuarios = new ReaLTaiizor.Controls.MetroButton();
            btnPedidoCozinha = new ReaLTaiizor.Controls.MetroButton();
            btnComanda = new ReaLTaiizor.Controls.MetroButton();
            btnCardapio = new ReaLTaiizor.Controls.MetroButton();
            btnSair = new ReaLTaiizor.Controls.CyberButton();
            dateTimePicker1 = new DateTimePicker();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.BackColor = Color.FromArgb(32, 41, 50);
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Controls.Add(btnPedidoCozinha);
            gpxPrincipal.Controls.Add(btnComanda);
            gpxPrincipal.Controls.Add(btnCardapio);
            gpxPrincipal.Location = new Point(52, 72);
            gpxPrincipal.MinimumSize = new Size(126, 50);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(837, 414);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuarios.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnUsuarios.DisabledForeColor = Color.Gray;
            btnUsuarios.Font = new Font("Microsoft Sans Serif", 10F);
            btnUsuarios.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnUsuarios.HoverColor = Color.FromArgb(95, 207, 255);
            btnUsuarios.HoverTextColor = Color.White;
            btnUsuarios.IsDerivedStyle = true;
            btnUsuarios.Location = new Point(607, 152);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnUsuarios.NormalColor = Color.Navy;
            btnUsuarios.NormalTextColor = Color.White;
            btnUsuarios.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressColor = Color.FromArgb(35, 147, 195);
            btnUsuarios.PressTextColor = Color.White;
            btnUsuarios.Size = new Size(180, 141);
            btnUsuarios.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnUsuarios.StyleManager = null;
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.ThemeAuthor = "Taiizor";
            btnUsuarios.ThemeName = "MetroLight";
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnPedidoCozinha.DisabledForeColor = Color.Gray;
            btnPedidoCozinha.Font = new Font("Microsoft Sans Serif", 10F);
            btnPedidoCozinha.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverColor = Color.FromArgb(95, 207, 255);
            btnPedidoCozinha.HoverTextColor = Color.White;
            btnPedidoCozinha.IsDerivedStyle = true;
            btnPedidoCozinha.Location = new Point(408, 152);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnPedidoCozinha.NormalColor = Color.Navy;
            btnPedidoCozinha.NormalTextColor = Color.White;
            btnPedidoCozinha.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressColor = Color.FromArgb(35, 147, 195);
            btnPedidoCozinha.PressTextColor = Color.White;
            btnPedidoCozinha.Size = new Size(180, 141);
            btnPedidoCozinha.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnPedidoCozinha.StyleManager = null;
            btnPedidoCozinha.TabIndex = 2;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.ThemeAuthor = "Taiizor";
            btnPedidoCozinha.ThemeName = "MetroLight";
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
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
            btnComanda.Location = new Point(205, 152);
            btnComanda.Name = "btnComanda";
            btnComanda.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnComanda.NormalColor = Color.Navy;
            btnComanda.NormalTextColor = Color.White;
            btnComanda.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressColor = Color.FromArgb(35, 147, 195);
            btnComanda.PressTextColor = Color.White;
            btnComanda.Size = new Size(180, 141);
            btnComanda.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnComanda.StyleManager = null;
            btnComanda.TabIndex = 1;
            btnComanda.Text = "Comanda";
            btnComanda.ThemeAuthor = "Taiizor";
            btnComanda.ThemeName = "MetroLight";
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.DisabledBackColor = Color.Blue;
            btnCardapio.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnCardapio.DisabledForeColor = Color.DeepSkyBlue;
            btnCardapio.Font = new Font("Microsoft Sans Serif", 10F);
            btnCardapio.ForeColor = SystemColors.Highlight;
            btnCardapio.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverColor = Color.FromArgb(95, 207, 255);
            btnCardapio.HoverTextColor = Color.White;
            btnCardapio.IsDerivedStyle = true;
            btnCardapio.Location = new Point(6, 152);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.NormalBorderColor = Color.Navy;
            btnCardapio.NormalColor = Color.Navy;
            btnCardapio.NormalTextColor = Color.White;
            btnCardapio.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressColor = Color.FromArgb(35, 147, 195);
            btnCardapio.PressTextColor = Color.White;
            btnCardapio.Size = new Size(180, 141);
            btnCardapio.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnCardapio.StyleManager = null;
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardapio";
            btnCardapio.ThemeAuthor = "Taiizor";
            btnCardapio.ThemeName = "MetroLight";
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnSair
            // 
            btnSair.Alpha = 20;
            btnSair.BackColor = Color.Transparent;
            btnSair.Background = true;
            btnSair.Background_WidthPen = 4F;
            btnSair.BackgroundPen = true;
            btnSair.ColorBackground = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSair.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnSair.ColorLighting = Color.FromArgb(29, 200, 238);
            btnSair.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSair.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSair.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSair.Effect_1 = true;
            btnSair.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSair.Effect_1_Transparency = 25;
            btnSair.Effect_2 = true;
            btnSair.Effect_2_ColorBackground = Color.White;
            btnSair.Effect_2_Transparency = 20;
            btnSair.Font = new Font("Arial", 11F);
            btnSair.ForeColor = Color.FromArgb(245, 245, 245);
            btnSair.Lighting = false;
            btnSair.LinearGradient_Background = false;
            btnSair.LinearGradientPen = false;
            btnSair.Location = new Point(52, 563);
            btnSair.Name = "btnSair";
            btnSair.PenWidth = 15;
            btnSair.Rounding = true;
            btnSair.RoundingInt = 70;
            btnSair.Size = new Size(195, 75);
            btnSair.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSair.TabIndex = 1;
            btnSair.Tag = "Cyber";
            btnSair.TextButton = "Sair";
            btnSair.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSair.Timer_Effect_1 = 5;
            btnSair.Timer_RGB = 300;
            btnSair.Click += btnSair_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(530, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(939, 673);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSair);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Comandos";
            TransparencyKey = Color.Fuchsia;
            Load += FrmPrincipal_Load;
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private ReaLTaiizor.Controls.MetroButton btnUsuarios;
        private ReaLTaiizor.Controls.MetroButton btnPedidoCozinha;
        private ReaLTaiizor.Controls.MetroButton btnComanda;
        private ReaLTaiizor.Controls.MetroButton btnCardapio;
        private ReaLTaiizor.Controls.CyberButton btnSair;
        private DateTimePicker dateTimePicker1;
    }
}
