using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;
using CalculatorLogic;

namespace Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView disp;
        StringManager obslugaStringow;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            obslugaStringow = new StringManager();
            disp = FindViewById<TextView>(Resource.Id.disp);
            Button btn1 = FindViewById<Button>(Resource.Id.button1);
            Button btn2 = FindViewById<Button>(Resource.Id.button2);
            Button btn3 = FindViewById<Button>(Resource.Id.button3);
            Button btn4 = FindViewById<Button>(Resource.Id.button4);
            Button btn5 = FindViewById<Button>(Resource.Id.button5);
            Button btn6 = FindViewById<Button>(Resource.Id.button6);
            Button btn7 = FindViewById<Button>(Resource.Id.button7);
            Button btn8 = FindViewById<Button>(Resource.Id.button8);
            Button btn9 = FindViewById<Button>(Resource.Id.button9);
            Button btnClr = FindViewById<Button>(Resource.Id.buttonClear);
            btn1.Click += AddDigitalByNumeralBtn;
            btn2.Click += AddDigitalByNumeralBtn;
            btn3.Click += AddDigitalByNumeralBtn;
            btn4.Click += AddDigitalByNumeralBtn;
            btn5.Click += AddDigitalByNumeralBtn;
            btn6.Click += AddDigitalByNumeralBtn;
            btn7.Click += AddDigitalByNumeralBtn;
            btn8.Click += AddDigitalByNumeralBtn;
            btn9.Click += AddDigitalByNumeralBtn;
            btnClr.Click += BtnClr_Click;
            
        }

        private void BtnClr_Click(object sender, System.EventArgs e)
        {
            disp.Text = "0";
        }

        private void AddDigitalByNumeralBtn(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            obslugaStringow.AddDigitToOperand(btn.Text);
            disp.Text += btn.Text;
        }
    }
}