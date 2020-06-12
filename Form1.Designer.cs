namespace SpaceShip
{
    partial class Form1
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
            this.playground = new System.Windows.Forms.Panel();
            this.Rounds = new System.Windows.Forms.Label();
            this.Score_Label = new System.Windows.Forms.Label();
            this.My_Health = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Load_SpaceShips = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playground.Controls.Add(this.Rounds);
            this.playground.Controls.Add(this.Score_Label);
            this.playground.Controls.Add(this.My_Health);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1163, 776);
            this.playground.TabIndex = 0;
            // 
            // Rounds
            // 
            this.Rounds.BackColor = System.Drawing.Color.Transparent;
            this.Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Rounds.ForeColor = System.Drawing.Color.White;
            this.Rounds.Location = new System.Drawing.Point(797, 9);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(281, 56);
            this.Rounds.TabIndex = 2;
            this.Rounds.Text = "Round : ";
            this.Rounds.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Score_Label
            // 
            this.Score_Label.BackColor = System.Drawing.Color.Transparent;
            this.Score_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Score_Label.ForeColor = System.Drawing.Color.Blue;
            this.Score_Label.Location = new System.Drawing.Point(431, 9);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(281, 56);
            this.Score_Label.TabIndex = 1;
            this.Score_Label.Text = "Score : 0";
            this.Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // My_Health
            // 
            this.My_Health.BackColor = System.Drawing.Color.Transparent;
            this.My_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.My_Health.ForeColor = System.Drawing.Color.Red;
            this.My_Health.Location = new System.Drawing.Point(90, 9);
            this.My_Health.Name = "My_Health";
            this.My_Health.Size = new System.Drawing.Size(281, 56);
            this.My_Health.TabIndex = 0;
            this.My_Health.Text = "Health";
            this.My_Health.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Load_SpaceShips
            // 
            this.Load_SpaceShips.Tick += new System.EventHandler(this.Load_SpaceShips_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(797, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score : 0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 56);
            this.label3.TabIndex = 0;
            this.label3.Text = "Health";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1163, 776);
            this.Controls.Add(this.playground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(-1000, 0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.playground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Load_SpaceShips;
        private System.Windows.Forms.Label My_Health;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Label Rounds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

