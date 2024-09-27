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
            btnNovo = new ReaLTaiizor.Controls.CyberButton();
            txtPesquisa = new ReaLTaiizor.Controls.CyberTextBox();
            dgvCardapio = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnEditar = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Alpha = 20;
            btnvoltar.BackColor = Color.Transparent;
            btnvoltar.Background = true;
            btnvoltar.Background_WidthPen = 4F;
            btnvoltar.BackgroundPen = true;
            btnvoltar.ColorBackground = Color.FromArgb(0, 0, 64);
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
            btnvoltar.Size = new Size(195, 71);
            btnvoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnvoltar.TabIndex = 0;
            btnvoltar.Tag = "Cyber";
            btnvoltar.TextButton = "< Voltar";
            btnvoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnvoltar.Timer_Effect_1 = 5;
            btnvoltar.Timer_RGB = 300;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Alpha = 20;
            btnNovo.BackColor = Color.Transparent;
            btnNovo.Background = true;
            btnNovo.Background_WidthPen = 4F;
            btnNovo.BackgroundPen = true;
            btnNovo.ColorBackground = Color.Crimson;
            btnNovo.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNovo.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnNovo.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNovo.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNovo.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNovo.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNovo.Effect_1 = true;
            btnNovo.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNovo.Effect_1_Transparency = 25;
            btnNovo.Effect_2 = true;
            btnNovo.Effect_2_ColorBackground = Color.White;
            btnNovo.Effect_2_Transparency = 20;
            btnNovo.Font = new Font("Arial", 11F);
            btnNovo.ForeColor = Color.FromArgb(245, 245, 245);
            btnNovo.Lighting = false;
            btnNovo.LinearGradient_Background = false;
            btnNovo.LinearGradientPen = false;
            btnNovo.Location = new Point(27, 71);
            btnNovo.Name = "btnNovo";
            btnNovo.PenWidth = 15;
            btnNovo.Rounding = true;
            btnNovo.RoundingInt = 70;
            btnNovo.Size = new Size(247, 53);
            btnNovo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNovo.TabIndex = 1;
            btnNovo.Tag = "Cyber";
            btnNovo.TextButton = "+ Novo Item Cardapio";
            btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNovo.Timer_Effect_1 = 5;
            btnNovo.Timer_RGB = 300;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Alpha = 20;
            txtPesquisa.BackColor = Color.Transparent;
            txtPesquisa.Background_WidthPen = 3F;
            txtPesquisa.BackgroundPen = true;
            txtPesquisa.ColorBackground = Color.FromArgb(0, 0, 64);
            txtPesquisa.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPesquisa.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPesquisa.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPesquisa.Font = new Font("Arial", 13F);
            txtPesquisa.ForeColor = Color.FromArgb(245, 245, 245);
            txtPesquisa.Lighting = false;
            txtPesquisa.LinearGradientPen = false;
            txtPesquisa.Location = new Point(22, 12);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PenWidth = 15;
            txtPesquisa.RGB = false;
            txtPesquisa.Rounding = true;
            txtPesquisa.RoundingInt = 60;
            txtPesquisa.Size = new Size(895, 53);
            txtPesquisa.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPesquisa.TabIndex = 2;
            txtPesquisa.Tag = "Cyber";
            txtPesquisa.TextButton = "Digite aqui para pesquisar";
            txtPesquisa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPesquisa.Timer_RGB = 300;
            // 
            // dgvCardapio
            // 
            dgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCardapio.Location = new Point(27, 141);
            dgvCardapio.Name = "dgvCardapio";
            dgvCardapio.RowHeadersWidth = 62;
            dgvCardapio.Size = new Size(880, 345);
            dgvCardapio.TabIndex = 3;
            dgvCardapio.CellClick += dgvCardapio_CellClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 4F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.Red;
            btnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Arial", 11F);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(482, 492);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(196, 75);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 4;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "X  Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Alpha = 20;
            btnEditar.BackColor = Color.Transparent;
            btnEditar.Background = true;
            btnEditar.Background_WidthPen = 4F;
            btnEditar.BackgroundPen = true;
            btnEditar.ColorBackground = Color.Lime;
            btnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnEditar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnEditar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEditar.Effect_1 = true;
            btnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEditar.Effect_1_Transparency = 25;
            btnEditar.Effect_2 = true;
            btnEditar.Effect_2_ColorBackground = Color.White;
            btnEditar.Effect_2_Transparency = 20;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial", 11F);
            btnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            btnEditar.Lighting = false;
            btnEditar.LinearGradient_Background = false;
            btnEditar.LinearGradientPen = false;
            btnEditar.Location = new Point(696, 492);
            btnEditar.Name = "btnEditar";
            btnEditar.PenWidth = 15;
            btnEditar.Rounding = true;
            btnEditar.RoundingInt = 70;
            btnEditar.Size = new Size(183, 75);
            btnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEditar.TabIndex = 5;
            btnEditar.Tag = "Cyber";
            btnEditar.TextButton = "# Editar";
            btnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Timer_Effect_1 = 5;
            btnEditar.Timer_RGB = 300;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 579);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvCardapio);
            Controls.Add(txtPesquisa);
            Controls.Add(btnNovo);
            Controls.Add(btnvoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardapio";
            ((System.ComponentModel.ISupportInitialize)dgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnvoltar;
        private ReaLTaiizor.Controls.CyberButton btnNovo;
        private ReaLTaiizor.Controls.CyberTextBox txtPesquisa;
        private DataGridView dgvCardapio;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberButton btnEditar;
    }
}