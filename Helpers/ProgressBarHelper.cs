namespace MattScerri.Fanatec.V3.PedalCurve.Helpers
{
    public static class ProgressBarHelper
    {
        //PB zlow meh https://stackoverflow.com/questions/977278/how-can-i-make-the-progress-bar-update-fast-enough
        public static void ValueFast(this ProgressBar progressBar, int value)
        {
            if (value < 100)    // prevent ArgumentException error on value = 100
            {
                progressBar.Value = value + 1;    // set the value +1
            }

            progressBar.Value = value;    // set the actual value

        }
    }
}
