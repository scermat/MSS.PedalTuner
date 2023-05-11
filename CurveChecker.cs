using MattScerri.Fanatec.V3.PedalCurve.CurveFilter;
using MattScerri.Fanatec.V3.PedalCurve.Pedal;

namespace MattScerri.Fanatec.V3.PedalCurve
{
    public partial class CurveChecker : Form
    {
        private int inputMinValue;
        private int inputMaxValue;
        private int outputMinValue;
        private int outputMaxValue;

        private CurveFilterType curveFilterType = CurveFilterType.Linear;

        private SignalFilter signalFilter;

        private RangeScale fromRange;
        private RangeScale toRange;

        private double dFactor;

        public CurveChecker()
        {
            InitializeComponent();

            SetParams();
        }

        private void SetParams()
        {
            dFactor = double.Parse(tbFactor.Text);

            inputMinValue = int.Parse(tbInputMinVal.Text);
            inputMaxValue = int.Parse(tbInputMaxVal.Text);
            outputMinValue = int.Parse(tbOutputMinVal.Text);
            outputMaxValue = int.Parse(tbOutputMaxVal.Text);

            fromRange = new RangeScale(inputMinValue, inputMaxValue);
            toRange = new RangeScale(outputMinValue, outputMaxValue);

            tbInput.Minimum = inputMinValue;
            tbInput.Maximum = inputMaxValue;

            tbOutput.Minimum = outputMinValue;
            tbOutput.Maximum = outputMaxValue;

            signalFilter = new SignalFilter(fromRange, toRange);
        }

        private void btnSetParams_Click(object sender, EventArgs e)
        {
            SetParams();
        }

        private void cbCurve_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.curveFilterType = CurveFilterHelper.CurveFilterLookup(cbCurve.SelectedItem.ToString() ?? string.Empty);
        }

        private void tbInput_ValueChanged(object sender, EventArgs e)
        {
            var rawOutput = signalFilter.Filter(curveFilterType, tbInput.Value, dFactor);
            var scaledOutput = (int)Math.Floor(fromRange.Rescale(toRange, rawOutput));

            tbOutput.Value = scaledOutput;

            UpdateTbValLabels();
        }

        private void UpdateTbValLabels()
        {
            lblInputVal.Text = tbInput.Value.ToString();
            lblOutputVal.Text = tbOutput.Value.ToString();
        }
    }
}
