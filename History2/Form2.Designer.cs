namespace History2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_incident = new System.Windows.Forms.Button();
            this.button_character = new System.Windows.Forms.Button();
            this.button_cultural = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\n";
            // 
            // button_incident
            // 
            this.button_incident.Font = new System.Drawing.Font("굴림", 16F);
            this.button_incident.Location = new System.Drawing.Point(40, 216);
            this.button_incident.Name = "button_incident";
            this.button_incident.Size = new System.Drawing.Size(251, 55);
            this.button_incident.TabIndex = 1;
            this.button_incident.Text = "관련 사건";
            this.button_incident.UseVisualStyleBackColor = true;
            this.button_incident.Click += new System.EventHandler(this.button_incident_Click);
            // 
            // button_character
            // 
            this.button_character.Font = new System.Drawing.Font("굴림", 16F);
            this.button_character.Location = new System.Drawing.Point(40, 289);
            this.button_character.Name = "button_character";
            this.button_character.Size = new System.Drawing.Size(251, 55);
            this.button_character.TabIndex = 2;
            this.button_character.Text = "관련 인물";
            this.button_character.UseVisualStyleBackColor = true;
            this.button_character.Click += new System.EventHandler(this.button_character_Click);
            // 
            // button_cultural
            // 
            this.button_cultural.Font = new System.Drawing.Font("굴림", 16F);
            this.button_cultural.Location = new System.Drawing.Point(40, 362);
            this.button_cultural.Name = "button_cultural";
            this.button_cultural.Size = new System.Drawing.Size(251, 55);
            this.button_cultural.TabIndex = 3;
            this.button_cultural.Text = "관련 문화재";
            this.button_cultural.UseVisualStyleBackColor = true;
            this.button_cultural.Click += new System.EventHandler(this.button_cultural_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cultural);
            this.Controls.Add(this.button_character);
            this.Controls.Add(this.button_incident);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "왕이름";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_incident;
        private System.Windows.Forms.Button button_character;
        private System.Windows.Forms.Button button_cultural;
        private System.Windows.Forms.Button button1;
    }
}