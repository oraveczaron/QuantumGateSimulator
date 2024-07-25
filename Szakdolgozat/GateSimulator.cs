using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using QuantumGateSimulator.Kapuk;

namespace QuantumGateSimulator
{
    public partial class GateSimulator : Form
    {
        #region Variables
        private Qubit qubit = new Qubit(0, 1);
        private Qubit newQubit = new Qubit(0, 1);

        private Queue<Gate> gates = new Queue<Gate>();

        QubitVisualization qubitVisualizationInput = new QubitVisualization();
        QubitVisualization qubitVisualizationOutput = new QubitVisualization();

        private Label lbl_0 = new Label();
        private Label lbl_1 = new Label();
        private Label lbl_fi = new Label();

        private Label newLbl_0 = new Label();
        private Label newLbl_1 = new Label();
        private Label newLbl_fi = new Label();
        #endregion

        public GateSimulator()
        {
            InitializeComponent();
            lbl_Qubit.Text = qubit.ToString();
            QubitVisualizationLabelSetup();
            lbl_Feedback.Text = "Form loaded succesfully";

        }
        private void QubitVisualizationLabelSetup()
        {
            lbl_0.Text = "|0⟩";
            lbl_1.Text = "|1⟩";
            lbl_fi.Text = "|ψ⟩";

            newLbl_0.Text = "|0⟩";
            newLbl_1.Text = "|1⟩";
            newLbl_fi.Text = "|ψ⟩";

            lbl_0.Width = 30;
            lbl_1.Width = 30;
            lbl_fi.Width = 30;

            newLbl_0.Width = 30;
            newLbl_1.Width = 30;
            newLbl_fi.Width = 30;


            this.Controls.Add(lbl_0);
            this.Controls.Add(lbl_1);
            this.Controls.Add(lbl_fi);

            this.Controls.Add(newLbl_0);
            this.Controls.Add(newLbl_1);
            this.Controls.Add(newLbl_fi);
        }

        private void GatesListboxUpdate()
        {
            lstbx_Gates.Items.Clear();
            foreach (Gate gate in gates)
            {
                lstbx_Gates.Items.Add(gate.name);
            }
            this.Invalidate();
        }

        private void GateQueueUpdate(Gate gate)
        {
            if (gates.Count < 5)
            {
                gates.Enqueue(gate);
                lbl_Feedback.Text = $"Gate added: {gate.name}";
                GatesListboxUpdate();
            }
            else
            {
                lbl_Feedback.Text = "A maximum of 5 gates can be displayed";
            }
        }
        #region GateButtons

        private void btn_Hadamard_Click(object sender, EventArgs e)
        {
            GateQueueUpdate(new Hadamard());
        }

        private void btn_PauliX_Click(object sender, EventArgs e)
        {
            GateQueueUpdate(new PauliX());
        }

        private void btn_PauliY_Click(object sender, EventArgs e)
        {
            GateQueueUpdate(new PauliY());
        }

        private void btn_PauliZ_Click(object sender, EventArgs e)
        {
            GateQueueUpdate(new PauliZ());
        }

        private void btn_Identification_Click(object sender, EventArgs e)
        {
            GateQueueUpdate(new IdentificationGate());
        }
        #endregion

        #region UniversalButtons

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static void RemoveLast(Queue<Gate> queue)
        {
            int size = queue.Count;
            for (int i = 0; i < size - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            queue.Dequeue();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (gates.Count > 0)
            {
                lbl_Feedback.Text = $"Gate withdrawn: {gates.Peek().name}";
                RemoveLast(gates);
                GatesListboxUpdate();
            }
            else
            {
                lbl_Feedback.Text = "There are no gates to withdraw";
            }
        }

        private void btn_Transform_Click(object sender, EventArgs e)
        {
            TransformGate();

        }
        private void btn_Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
        #endregion
        private void TransformGate()
        {
            panel_MatrixTransformations.Controls.Clear();
            AddGateTransfomationQubitLabel(qubit);

            newQubit = new Qubit(qubit);
            if (gates.Count > 0)
            {
                foreach (Gate gate in gates)
                {
                    newQubit.Transforms(gate);
                    AddGateTransformationLabel(gate);
                }
                AddGateTransformationEqualationMarkLabel();
                AddGateTransfomationQubitLabel(newQubit);
                lbl_NewQubit.Text = newQubit.ToString();
                this.Invalidate();
                lbl_Feedback.Text = "Transform successful";
            }
            else
            {
                lbl_Feedback.Text = "No gate specified";
            }
        }

        #region GateTransformationLabels
        private void AddGateTransfomationQubitLabel(Qubit qubit)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Margin = new Padding(5);
            label.Text = qubit.VectorToString();
            panel_MatrixTransformations.Controls.Add(label);
        }
        private void AddGateTransformationEqualationMarkLabel()
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Margin = new Padding(5);
            label.Text = $"\n=";
            panel_MatrixTransformations.Controls.Add(label);
        }

        private void AddGateTransformationLabel(Gate kapu)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Margin = new Padding(5); 

            label.Text = kapu.ToString();

            panel_MatrixTransformations.Controls.Add(label);
        }
        #endregion

        private void GateSimulator_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            qubitVisualizationInput = new QubitVisualization(g, 100, 150, 400, qubit.GetAmplitude0(), qubit.GetAmplitude1());
            qubitVisualizationOutput = new QubitVisualization(g, 100, 700, 400, newQubit.GetAmplitude0(), newQubit.GetAmplitude1());

            lbl_0.Location = new Point(qubitVisualizationInput.GetCenterX() + qubitVisualizationInput.GetRadius() + 10, qubitVisualizationInput.GetCenterY() - 7);
            lbl_1.Location = new Point(qubitVisualizationInput.GetCenterX() - 6, qubitVisualizationInput.GetCenterY() - qubitVisualizationInput.GetRadius() - 25);

            newLbl_0.Location = new Point(qubitVisualizationOutput.GetCenterX() + qubitVisualizationOutput.GetRadius() + 10, qubitVisualizationOutput.GetCenterY() - 7);
            newLbl_1.Location = new Point(qubitVisualizationOutput.GetCenterX() - 6, qubitVisualizationOutput.GetCenterY() - qubitVisualizationOutput.GetRadius() - 25);

            PozitionQubitVisualizationLabel(qubitVisualizationInput, qubit, lbl_fi);
            PozitionQubitVisualizationLabel(qubitVisualizationOutput, newQubit, newLbl_fi);
            GateVisualization(100, 100, g);
        }
        private void PozitionQubitVisualizationLabel(QubitVisualization qubitVisualization, Qubit qubit, Label label)
        {


            double fiX = qubitVisualization.GetCenterX() + (qubitVisualization.GetRadius() + 40) * qubit.GetAmplitude0(); 
            double fiY = qubitVisualization.GetCenterY() - (qubitVisualization.GetRadius() + 40) * qubit.GetAmplitude1(); 
            label.Location = new Point((int)fiX, (int)fiY);


        }
        private void GateVisualization(int y, int distance, Graphics g)
        {
            foreach (Gate gate in gates)
            {
                gate.DisplayGate(g, new Pen(Color.Black), new Point(distance, y));
                distance += 100;
            }
        }


        private void tb_amplitudes_Scroll(object sender, EventArgs e)
        {
            double theta = tb_amplitudes.Value * Math.PI / tb_amplitudes.Maximum * 2;

            qubit.SetAmplitude0(Math.Cos(theta));
            qubit.SetAmplitude1(Math.Sin(theta));

            lbl_Qubit.Text = qubit.ToString();

            this.Invalidate();
        }


    }
}