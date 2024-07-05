namespace Comandas
{
    partial class frmCardapio
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
            btnvoltar = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Alpha = 20;
            btnvoltar.BackColor = Color.Transparent;
            btnvoltar.Background = true;
            btnvoltar.Background_WidthPen = 4F;
            btnvoltar.BackgroundPen = true;
            btnvoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnvoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnvoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnvoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnvoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnvoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnvoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnvoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnvoltar.Effect_1 = true;
            btnvoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnvoltar.Effect_1_Transparency = 25;
            btnvoltar.Effect_2 = true;
            btnvoltar.Effect_2_ColorBackground = Color.White;
            btnvoltar.Effect_2_Transparency = 20;
            btnvoltar.Font = new Font("Arial", 11F);
            btnvoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnvoltar.Lighting = false;
            btnvoltar.LinearGradient_Background = false;
            btnvoltar.LinearGradientPen = false;
            btnvoltar.Location = new Point(38, 496);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.PenWidth = 15;
            btnvoltar.Rounding = true;
            btnvoltar.RoundingInt = 70;
            btnvoltar.Size = new Size(195, 75);
            btnvoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnvoltar.TabIndex = 0;
            btnvoltar.Tag = "Cyber";
            btnvoltar.TextButton = "voltar";
            btnvoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnvoltar.Timer_Effect_1 = 5;
            btnvoltar.Timer_RGB = 300;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(12, 71);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(206, 39);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 1;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "CyberButton";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // frmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 592);
            Controls.Add(cyberButton1);
            Controls.Add(btnvoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardapio";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnvoltar;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}