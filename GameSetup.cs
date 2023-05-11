using MattScerri.Fanatec.V3.PedalCurve.Pedal;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public partial class GameSetup : Form
    {
        private PedalOutput pedalOutput;
        public GameSetup(PedalOutput pedalOutput)
        {
            InitializeComponent();

            this.pedalOutput = pedalOutput;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetMin_Click(object sender, EventArgs e)
        {
            pedalOutput.ForceOutput(pedalOutput.GetOutputRange().MinValue);
        }

        private void btnSetMax_Click(object sender, EventArgs e)
        {
            pedalOutput.ForceOutput(pedalOutput.GetOutputRange().MaxValue);
        }
    }
}
