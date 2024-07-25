namespace QuantumGateSimulator
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Sugo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(16, 185);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Vissza_Click);
            // 
            // lbl_Sugo
            // 
            this.lbl_Sugo.AutoSize = true;
            this.lbl_Sugo.Location = new System.Drawing.Point(16, 12);
            this.lbl_Sugo.Name = "lbl_Sugo";
            this.lbl_Sugo.Size = new System.Drawing.Size(353, 165);
            this.lbl_Sugo.TabIndex = 1;
            this.lbl_Sugo.Text = resources.GetString("lbl_Sugo.Text");
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 220);
            this.Controls.Add(this.lbl_Sugo);
            this.Controls.Add(this.btn_Back);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Back;
        private Label lbl_Sugo;
    }
}