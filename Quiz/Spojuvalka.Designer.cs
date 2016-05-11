namespace Quiz
{
    partial class Spojuvalka
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
            this.lstLevo = new System.Windows.Forms.ListBox();
            this.lstDesno = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.btnNextGame = new System.Windows.Forms.Button();
            this.txtBoxSign = new System.Windows.Forms.TextBox();
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.btnPravila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLevo
            // 
            this.lstLevo.BackColor = System.Drawing.Color.White;
            this.lstLevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLevo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstLevo.FormattingEnabled = true;
            this.lstLevo.ItemHeight = 29;
            this.lstLevo.Location = new System.Drawing.Point(12, 86);
            this.lstLevo.Name = "lstLevo";
            this.lstLevo.Size = new System.Drawing.Size(276, 323);
            this.lstLevo.TabIndex = 0;
            this.lstLevo.SelectedIndexChanged += new System.EventHandler(this.lstLevo_SelectedIndexChanged);
            // 
            // lstDesno
            // 
            this.lstDesno.BackColor = System.Drawing.Color.White;
            this.lstDesno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDesno.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstDesno.FormattingEnabled = true;
            this.lstDesno.ItemHeight = 29;
            this.lstDesno.Location = new System.Drawing.Point(431, 86);
            this.lstDesno.Name = "lstDesno";
            this.lstDesno.Size = new System.Drawing.Size(276, 323);
            this.lstDesno.TabIndex = 1;
            this.lstDesno.SelectedIndexChanged += new System.EventHandler(this.lstDesno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoeni.Location = new System.Drawing.Point(71, 428);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(15, 16);
            this.lblPoeni.TabIndex = 3;
            this.lblPoeni.Text = "0";
            // 
            // btnNextGame
            // 
            this.btnNextGame.BackColor = System.Drawing.Color.White;
            this.btnNextGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnNextGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextGame.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnNextGame.Location = new System.Drawing.Point(587, 428);
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Size = new System.Drawing.Size(111, 39);
            this.btnNextGame.TabIndex = 4;
            this.btnNextGame.Text = "Следна игра";
            this.btnNextGame.UseVisualStyleBackColor = false;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // txtBoxSign
            // 
            this.txtBoxSign.BackColor = System.Drawing.Color.White;
            this.txtBoxSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSign.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxSign.Location = new System.Drawing.Point(294, 86);
            this.txtBoxSign.Multiline = true;
            this.txtBoxSign.Name = "txtBoxSign";
            this.txtBoxSign.Size = new System.Drawing.Size(131, 323);
            this.txtBoxSign.TabIndex = 5;
            this.txtBoxSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSign.Visible = false;
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.BackColor = System.Drawing.Color.White;
            this.txtBoxOpis.Enabled = false;
            this.txtBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOpis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtBoxOpis.Location = new System.Drawing.Point(84, 5);
            this.txtBoxOpis.Multiline = true;
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(555, 35);
            this.txtBoxOpis.TabIndex = 6;
            // 
            // btnPravila
            // 
            this.btnPravila.BackColor = System.Drawing.Color.White;
            this.btnPravila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnPravila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPravila.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPravila.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnPravila.Location = new System.Drawing.Point(12, 46);
            this.btnPravila.Name = "btnPravila";
            this.btnPravila.Size = new System.Drawing.Size(105, 34);
            this.btnPravila.TabIndex = 7;
            this.btnPravila.Text = "Правила";
            this.btnPravila.UseVisualStyleBackColor = false;
            this.btnPravila.Click += new System.EventHandler(this.btnPravila_Click);
            // 
            // Spojuvalka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 479);
            this.Controls.Add(this.btnPravila);
            this.Controls.Add(this.txtBoxOpis);
            this.Controls.Add(this.txtBoxSign);
            this.Controls.Add(this.btnNextGame);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDesno);
            this.Controls.Add(this.lstLevo);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Spojuvalka";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спојувалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLevo;
        private System.Windows.Forms.ListBox lstDesno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Button btnNextGame;
        private System.Windows.Forms.TextBox txtBoxSign;
        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.Button btnPravila;
    }
}

