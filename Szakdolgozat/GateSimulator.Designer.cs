namespace QuantumGateSimulator
{
    partial class GateSimulator
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
            this.lbl_Qubit = new System.Windows.Forms.Label();
            this.btn_Hadamard = new System.Windows.Forms.Button();
            this.btn_PauliX = new System.Windows.Forms.Button();
            this.btn_PauliY = new System.Windows.Forms.Button();
            this.btn_PauliZ = new System.Windows.Forms.Button();
            this.btn_Transzform = new System.Windows.Forms.Button();
            this.btn_Vissza = new System.Windows.Forms.Button();
            this.lbl_Feedback = new System.Windows.Forms.Label();
            this.lstbx_Gates = new System.Windows.Forms.ListBox();
            this.btn_Identifikacio = new System.Windows.Forms.Button();
            this.tb_amplitudes = new System.Windows.Forms.TrackBar();
            this.btn_Sugo = new System.Windows.Forms.Button();
            this.btn_Kilepes = new System.Windows.Forms.Button();
            this.lbl_KapuTranszformaciok = new System.Windows.Forms.Label();
            this.panel_MatrixTransformations = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_NewQubit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_amplitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Qubit
            // 
            this.lbl_Qubit.AutoSize = true;
            this.lbl_Qubit.Location = new System.Drawing.Point(95, 195);
            this.lbl_Qubit.Name = "lbl_Qubit";
            this.lbl_Qubit.Size = new System.Drawing.Size(37, 15);
            this.lbl_Qubit.TabIndex = 7;
            this.lbl_Qubit.Text = "|ψ⟩ = ";
            // 
            // btn_Hadamard
            // 
            this.btn_Hadamard.BackColor = System.Drawing.Color.White;
            this.btn_Hadamard.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_Hadamard.Location = new System.Drawing.Point(181, 12);
            this.btn_Hadamard.Name = "btn_Hadamard";
            this.btn_Hadamard.Size = new System.Drawing.Size(50, 50);
            this.btn_Hadamard.TabIndex = 29;
            this.btn_Hadamard.Text = "H";
            this.btn_Hadamard.UseVisualStyleBackColor = false;
            this.btn_Hadamard.Click += new System.EventHandler(this.btn_Hadamard_Click);
            // 
            // btn_PauliX
            // 
            this.btn_PauliX.BackColor = System.Drawing.Color.White;
            this.btn_PauliX.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_PauliX.Location = new System.Drawing.Point(237, 12);
            this.btn_PauliX.Name = "btn_PauliX";
            this.btn_PauliX.Size = new System.Drawing.Size(50, 50);
            this.btn_PauliX.TabIndex = 30;
            this.btn_PauliX.Text = "X";
            this.btn_PauliX.UseVisualStyleBackColor = false;
            this.btn_PauliX.Click += new System.EventHandler(this.btn_PauliX_Click);
            // 
            // btn_PauliY
            // 
            this.btn_PauliY.BackColor = System.Drawing.Color.White;
            this.btn_PauliY.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_PauliY.Location = new System.Drawing.Point(293, 12);
            this.btn_PauliY.Name = "btn_PauliY";
            this.btn_PauliY.Size = new System.Drawing.Size(50, 50);
            this.btn_PauliY.TabIndex = 31;
            this.btn_PauliY.Text = "Y";
            this.btn_PauliY.UseVisualStyleBackColor = false;
            this.btn_PauliY.Click += new System.EventHandler(this.btn_PauliY_Click);
            // 
            // btn_PauliZ
            // 
            this.btn_PauliZ.BackColor = System.Drawing.Color.White;
            this.btn_PauliZ.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_PauliZ.Location = new System.Drawing.Point(349, 12);
            this.btn_PauliZ.Name = "btn_PauliZ";
            this.btn_PauliZ.Size = new System.Drawing.Size(50, 50);
            this.btn_PauliZ.TabIndex = 32;
            this.btn_PauliZ.Text = "Z";
            this.btn_PauliZ.UseVisualStyleBackColor = false;
            this.btn_PauliZ.Click += new System.EventHandler(this.btn_PauliZ_Click);
            // 
            // btn_Transzform
            // 
            this.btn_Transzform.Location = new System.Drawing.Point(588, 87);
            this.btn_Transzform.Name = "btn_Transzform";
            this.btn_Transzform.Size = new System.Drawing.Size(98, 23);
            this.btn_Transzform.TabIndex = 33;
            this.btn_Transzform.Text = "Transform";
            this.btn_Transzform.UseVisualStyleBackColor = true;
            this.btn_Transzform.Click += new System.EventHandler(this.btn_Transform_Click);
            // 
            // btn_Vissza
            // 
            this.btn_Vissza.Location = new System.Drawing.Point(588, 58);
            this.btn_Vissza.Name = "btn_Vissza";
            this.btn_Vissza.Size = new System.Drawing.Size(75, 23);
            this.btn_Vissza.TabIndex = 34;
            this.btn_Vissza.Text = "Back";
            this.btn_Vissza.UseVisualStyleBackColor = true;
            this.btn_Vissza.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Feedback
            // 
            this.lbl_Feedback.AutoSize = true;
            this.lbl_Feedback.Location = new System.Drawing.Point(588, 38);
            this.lbl_Feedback.Name = "lbl_Feedback";
            this.lbl_Feedback.Size = new System.Drawing.Size(57, 15);
            this.lbl_Feedback.TabIndex = 35;
            this.lbl_Feedback.Text = "Feedback";
            // 
            // lstbx_Gates
            // 
            this.lstbx_Gates.FormattingEnabled = true;
            this.lstbx_Gates.ItemHeight = 15;
            this.lstbx_Gates.Location = new System.Drawing.Point(588, 116);
            this.lstbx_Gates.Name = "lstbx_Gates";
            this.lstbx_Gates.Size = new System.Drawing.Size(120, 94);
            this.lstbx_Gates.TabIndex = 36;
            // 
            // btn_Identifikacio
            // 
            this.btn_Identifikacio.BackColor = System.Drawing.Color.White;
            this.btn_Identifikacio.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_Identifikacio.Location = new System.Drawing.Point(405, 12);
            this.btn_Identifikacio.Name = "btn_Identifikacio";
            this.btn_Identifikacio.Size = new System.Drawing.Size(50, 50);
            this.btn_Identifikacio.TabIndex = 37;
            this.btn_Identifikacio.Text = "I";
            this.btn_Identifikacio.UseVisualStyleBackColor = false;
            this.btn_Identifikacio.Click += new System.EventHandler(this.btn_Identification_Click);
            // 
            // tb_amplitudes
            // 
            this.tb_amplitudes.LargeChange = 10;
            this.tb_amplitudes.Location = new System.Drawing.Point(36, 213);
            this.tb_amplitudes.Maximum = 1000;
            this.tb_amplitudes.Name = "tb_amplitudes";
            this.tb_amplitudes.Size = new System.Drawing.Size(291, 45);
            this.tb_amplitudes.SmallChange = 10;
            this.tb_amplitudes.TabIndex = 39;
            this.tb_amplitudes.Value = 250;
            this.tb_amplitudes.Scroll += new System.EventHandler(this.tb_amplitudes_Scroll);
            // 
            // btn_Sugo
            // 
            this.btn_Sugo.Location = new System.Drawing.Point(12, 12);
            this.btn_Sugo.Name = "btn_Sugo";
            this.btn_Sugo.Size = new System.Drawing.Size(75, 23);
            this.btn_Sugo.TabIndex = 40;
            this.btn_Sugo.Text = "Help";
            this.btn_Sugo.UseVisualStyleBackColor = true;
            this.btn_Sugo.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Kilepes
            // 
            this.btn_Kilepes.Location = new System.Drawing.Point(806, 526);
            this.btn_Kilepes.Name = "btn_Kilepes";
            this.btn_Kilepes.Size = new System.Drawing.Size(75, 23);
            this.btn_Kilepes.TabIndex = 44;
            this.btn_Kilepes.Text = "Quit";
            this.btn_Kilepes.UseVisualStyleBackColor = true;
            this.btn_Kilepes.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_KapuTranszformaciok
            // 
            this.lbl_KapuTranszformaciok.AutoSize = true;
            this.lbl_KapuTranszformaciok.Location = new System.Drawing.Point(333, 195);
            this.lbl_KapuTranszformaciok.Name = "lbl_KapuTranszformaciok";
            this.lbl_KapuTranszformaciok.Size = new System.Drawing.Size(90, 15);
            this.lbl_KapuTranszformaciok.TabIndex = 45;
            this.lbl_KapuTranszformaciok.Text = "Transformation:";
            // 
            // panel_MatrixTransformations
            // 
            this.panel_MatrixTransformations.AutoScroll = true;
            this.panel_MatrixTransformations.Location = new System.Drawing.Point(333, 213);
            this.panel_MatrixTransformations.Name = "panel_MatrixTransformations";
            this.panel_MatrixTransformations.Size = new System.Drawing.Size(217, 137);
            this.panel_MatrixTransformations.TabIndex = 46;
            // 
            // lbl_NewQubit
            // 
            this.lbl_NewQubit.AutoSize = true;
            this.lbl_NewQubit.Location = new System.Drawing.Point(649, 213);
            this.lbl_NewQubit.Name = "lbl_NewQubit";
            this.lbl_NewQubit.Size = new System.Drawing.Size(37, 15);
            this.lbl_NewQubit.TabIndex = 47;
            this.lbl_NewQubit.Text = "|ψ⟩ = ";
            // 
            // GateSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 561);
            this.Controls.Add(this.lbl_NewQubit);
            this.Controls.Add(this.lbl_KapuTranszformaciok);
            this.Controls.Add(this.panel_MatrixTransformations);
            this.Controls.Add(this.btn_Kilepes);
            this.Controls.Add(this.btn_Sugo);
            this.Controls.Add(this.tb_amplitudes);
            this.Controls.Add(this.btn_Identifikacio);
            this.Controls.Add(this.lstbx_Gates);
            this.Controls.Add(this.lbl_Feedback);
            this.Controls.Add(this.btn_Vissza);
            this.Controls.Add(this.btn_Transzform);
            this.Controls.Add(this.btn_PauliZ);
            this.Controls.Add(this.btn_PauliY);
            this.Controls.Add(this.btn_PauliX);
            this.Controls.Add(this.btn_Hadamard);
            this.Controls.Add(this.lbl_Qubit);
            this.Name = "GateSimulator";
            this.Text = "Quantum-logical Gate Simulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GateSimulator_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tb_amplitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Qubit;
        private Button btn_Hadamard;
        private Button btn_PauliX;
        private Button btn_PauliY;
        private Button btn_PauliZ;
        private Button btn_Transzform;
        private Button btn_Vissza;
        private Label lbl_Feedback;
        private ListBox lstbx_Gates;
        private Button btn_Identifikacio;
        private TrackBar tb_amplitudes;
        private Button btn_Sugo;
        private Button btn_Kilepes;
        private Label lbl_KapuTranszformaciok;
        private FlowLayoutPanel panel_MatrixTransformations;
        private Label lbl_NewQubit;
    }
}