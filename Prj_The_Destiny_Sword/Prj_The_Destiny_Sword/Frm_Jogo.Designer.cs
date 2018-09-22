namespace Prj_The_Destiny_Sword
{
    partial class Frm_Jogo
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
            this.lbl_Historia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Historia
            // 
            this.lbl_Historia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Historia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Historia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Historia.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Historia.Location = new System.Drawing.Point(12, 9);
            this.lbl_Historia.Name = "lbl_Historia";
            this.lbl_Historia.Size = new System.Drawing.Size(676, 155);
            this.lbl_Historia.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 493);
            this.Controls.Add(this.lbl_Historia);
            this.Name = "Frm_Jogo";
            this.ShowIcon = false;
            this.Text = "The Destiny Sword";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Historia;
        private System.Windows.Forms.Timer timer1;
    }
}