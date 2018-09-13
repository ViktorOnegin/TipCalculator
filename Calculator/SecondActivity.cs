using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Calculator
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_second);
            SetContentView(Resource.Layout.activity_main);

            var backButton = FindViewById<Button>(Resource.Id.button1);

            backButton.Click += BackButton_Click;
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            var mainActivity = new Intent(this, typeof(MainActivity));
            StartActivity(mainActivity);
        }
    }
}