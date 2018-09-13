using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Calculator
{
    //Tipp amount:  bill amount * tip / 100
    //total payment: bill amount + tip amount


    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView textView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            textView = FindViewById<TextView>(Resource.Id.textView1);
            var SeekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            var calculateButton = FindViewById<Button>(Resource.Id.button1);

            SeekBar.ProgressChanged += SeekBar_ProgressChanged;
            calculateButton.Click += CalculateButton_Click;
        }

        private void CalculateButton_Click(object sender, System.EventArgs e)
        {
            var secondActivity = new Intent(this, typeof(SecondActivity));
            StartActivity(secondActivity);
        }

        private void SeekBar_ProgressChanged(object sender, SeekBar.ProgressChangedEventArgs e)
        {
            textView.Text = e.Progress.ToString();
        }
    }
}