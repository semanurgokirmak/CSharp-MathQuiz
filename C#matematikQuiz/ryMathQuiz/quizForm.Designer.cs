namespace ryMathQuiz
{
    partial class quizForm
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
            this.quizBar = new System.Windows.Forms.ToolStrip();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bolSagSayi = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bolSolSayi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carpSagSayi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carpSolSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cikarSagSayi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cikarSolSayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toplaSagSayi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toplaSolSayi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sureGoster = new System.Windows.Forms.Label();
            this.nudBol = new System.Windows.Forms.NumericUpDown();
            this.nudCarp = new System.Windows.Forms.NumericUpDown();
            this.nudCikar = new System.Windows.Forms.NumericUpDown();
            this.nudTopla = new System.Windows.Forms.NumericUpDown();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.quizBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopla)).BeginInit();
            this.SuspendLayout();
            // 
            // quizBar
            // 
            this.quizBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.quizBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKapat});
            this.quizBar.Location = new System.Drawing.Point(0, 0);
            this.quizBar.Name = "quizBar";
            this.quizBar.Size = new System.Drawing.Size(400, 39);
            this.quizBar.TabIndex = 18;
            this.quizBar.Text = "toolStrip1";
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKapat.Image = global::ryMathQuiz.Properties.Resources.kapat;
            this.btnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(36, 36);
            this.btnKapat.ToolTipText = "Çıkış";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.AutoSize = true;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaslat.Location = new System.Drawing.Point(216, 341);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(154, 40);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Text = "Sınavı Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(166, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 43;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bolSagSayi
            // 
            this.bolSagSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolSagSayi.Location = new System.Drawing.Point(112, 276);
            this.bolSagSayi.Name = "bolSagSayi";
            this.bolSagSayi.Size = new System.Drawing.Size(60, 50);
            this.bolSagSayi.TabIndex = 42;
            this.bolSagSayi.Text = "?";
            this.bolSagSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(61, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 41;
            this.label12.Text = "÷";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bolSolSayi
            // 
            this.bolSolSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolSolSayi.Location = new System.Drawing.Point(10, 276);
            this.bolSolSayi.Name = "bolSolSayi";
            this.bolSolSayi.Size = new System.Drawing.Size(60, 50);
            this.bolSolSayi.TabIndex = 40;
            this.bolSolSayi.Text = "?";
            this.bolSolSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(168, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 39;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carpSagSayi
            // 
            this.carpSagSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpSagSayi.Location = new System.Drawing.Point(114, 221);
            this.carpSagSayi.Name = "carpSagSayi";
            this.carpSagSayi.Size = new System.Drawing.Size(60, 50);
            this.carpSagSayi.TabIndex = 38;
            this.carpSagSayi.Text = "?";
            this.carpSagSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(63, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 37;
            this.label8.Text = "×";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carpSolSayi
            // 
            this.carpSolSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpSolSayi.Location = new System.Drawing.Point(12, 221);
            this.carpSolSayi.Name = "carpSolSayi";
            this.carpSolSayi.Size = new System.Drawing.Size(60, 50);
            this.carpSolSayi.TabIndex = 36;
            this.carpSolSayi.Text = "?";
            this.carpSolSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(168, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 35;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikarSagSayi
            // 
            this.cikarSagSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarSagSayi.Location = new System.Drawing.Point(114, 164);
            this.cikarSagSayi.Name = "cikarSagSayi";
            this.cikarSagSayi.Size = new System.Drawing.Size(60, 50);
            this.cikarSagSayi.TabIndex = 34;
            this.cikarSagSayi.Text = "?";
            this.cikarSagSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(63, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 33;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikarSolSayi
            // 
            this.cikarSolSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarSolSayi.Location = new System.Drawing.Point(12, 164);
            this.cikarSolSayi.Name = "cikarSolSayi";
            this.cikarSolSayi.Size = new System.Drawing.Size(60, 50);
            this.cikarSolSayi.TabIndex = 32;
            this.cikarSolSayi.Text = "?";
            this.cikarSolSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(168, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 30;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplaSagSayi
            // 
            this.toplaSagSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplaSagSayi.Location = new System.Drawing.Point(114, 108);
            this.toplaSagSayi.Name = "toplaSagSayi";
            this.toplaSagSayi.Size = new System.Drawing.Size(60, 50);
            this.toplaSagSayi.TabIndex = 29;
            this.toplaSagSayi.Text = "?";
            this.toplaSagSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 27;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplaSolSayi
            // 
            this.toplaSolSayi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplaSolSayi.Location = new System.Drawing.Point(12, 108);
            this.toplaSolSayi.Name = "toplaSolSayi";
            this.toplaSolSayi.Size = new System.Drawing.Size(60, 50);
            this.toplaSolSayi.TabIndex = 24;
            this.toplaSolSayi.Text = "?";
            this.toplaSolSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kalan Süre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sureGoster
            // 
            this.sureGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sureGoster.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureGoster.Location = new System.Drawing.Point(195, 56);
            this.sureGoster.Name = "sureGoster";
            this.sureGoster.Size = new System.Drawing.Size(193, 39);
            this.sureGoster.TabIndex = 21;
            this.sureGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudBol
            // 
            this.nudBol.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBol.Location = new System.Drawing.Point(223, 285);
            this.nudBol.Name = "nudBol";
            this.nudBol.Size = new System.Drawing.Size(136, 37);
            this.nudBol.TabIndex = 4;
            this.nudBol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBol.Enter += new System.EventHandler(this.SonucGirisKontrolu);
            // 
            // nudCarp
            // 
            this.nudCarp.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCarp.Location = new System.Drawing.Point(223, 230);
            this.nudCarp.Name = "nudCarp";
            this.nudCarp.Size = new System.Drawing.Size(136, 37);
            this.nudCarp.TabIndex = 3;
            this.nudCarp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCarp.Enter += new System.EventHandler(this.SonucGirisKontrolu);
            // 
            // nudCikar
            // 
            this.nudCikar.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCikar.Location = new System.Drawing.Point(223, 173);
            this.nudCikar.Name = "nudCikar";
            this.nudCikar.Size = new System.Drawing.Size(136, 37);
            this.nudCikar.TabIndex = 2;
            this.nudCikar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCikar.Enter += new System.EventHandler(this.SonucGirisKontrolu);
            // 
            // nudTopla
            // 
            this.nudTopla.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTopla.Location = new System.Drawing.Point(223, 117);
            this.nudTopla.Name = "nudTopla";
            this.nudTopla.Size = new System.Drawing.Size(136, 37);
            this.nudTopla.TabIndex = 1;
            this.nudTopla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTopla.Enter += new System.EventHandler(this.SonucGirisKontrolu);
            // 
            // saat
            // 
            this.saat.Interval = 1000;
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // quizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 408);
            this.ControlBox = false;
            this.Controls.Add(this.nudBol);
            this.Controls.Add(this.nudCarp);
            this.Controls.Add(this.nudCikar);
            this.Controls.Add(this.nudTopla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bolSagSayi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bolSolSayi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.carpSagSayi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.carpSolSayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cikarSagSayi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cikarSolSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toplaSagSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toplaSolSayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sureGoster);
            this.Controls.Add(this.quizBar);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "quizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATEMATIKSEL İŞLEMLER";
            this.quizBar.ResumeLayout(false);
            this.quizBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCikar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip quizBar;
        private System.Windows.Forms.ToolStripButton btnKapat;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bolSagSayi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label bolSolSayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label carpSagSayi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label carpSolSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cikarSagSayi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cikarSolSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplaSagSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toplaSolSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sureGoster;
        private System.Windows.Forms.NumericUpDown nudBol;
        private System.Windows.Forms.NumericUpDown nudCarp;
        private System.Windows.Forms.NumericUpDown nudCikar;
        private System.Windows.Forms.NumericUpDown nudTopla;
        private System.Windows.Forms.Timer saat;
    }
}

