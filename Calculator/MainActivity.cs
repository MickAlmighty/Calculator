using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Support.Design.Widget;
using CalculatorLogic;
using System;
using System.Collections.Generic;

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
            Button btn0 = FindViewById<Button>(Resource.Id.button0);
            Button btn1 = FindViewById<Button>(Resource.Id.button1);
            Button btn2 = FindViewById<Button>(Resource.Id.button2);
            Button btn3 = FindViewById<Button>(Resource.Id.button3);
            Button btn4 = FindViewById<Button>(Resource.Id.button4);
            Button btn5 = FindViewById<Button>(Resource.Id.button5);
            Button btn6 = FindViewById<Button>(Resource.Id.button6);
            Button btn7 = FindViewById<Button>(Resource.Id.button7);
            Button btn8 = FindViewById<Button>(Resource.Id.button8);
            Button btn9 = FindViewById<Button>(Resource.Id.button9);
            Button btnDot = FindViewById<Button>(Resource.Id.buttonDot);
            Button btnClr = FindViewById<Button>(Resource.Id.buttonClear);
            Button btnAdd = FindViewById<Button>(Resource.Id.buttonAdd);
            Button btnExec = FindViewById<Button>(Resource.Id.buttonEqualSign);
            Button btnPercentage = FindViewById<Button>(Resource.Id.buttonPercentage);
            Button btnPlusMinus = FindViewById<Button>(Resource.Id.buttonPlusMinus);
            Button btnMult = FindViewById<Button>(Resource.Id.buttonMult);
            Button btnDiv = FindViewById<Button>(Resource.Id.buttonDivision);
            Button btnSub = FindViewById<Button>(Resource.Id.buttonSub);

            btn0.Click += AddDigitByNumeralBtn;
            btn1.Click += AddDigitByNumeralBtn;
            btn2.Click += AddDigitByNumeralBtn;
            btn3.Click += AddDigitByNumeralBtn;
            btn4.Click += AddDigitByNumeralBtn;
            btn5.Click += AddDigitByNumeralBtn;
            btn6.Click += AddDigitByNumeralBtn;
            btn7.Click += AddDigitByNumeralBtn;
            btn8.Click += AddDigitByNumeralBtn;
            btn9.Click += AddDigitByNumeralBtn;
            btnDot.Click += AddDigitByNumeralBtn;
            btnClr.Click += BtnClr_Click;
            btnAdd.Click += SwitchOperation;
            btnPercentage.Click += SwitchOperation;
            btnMult.Click += SwitchOperation;
            btnDiv.Click += SwitchOperation;
            btnSub.Click += SwitchOperation;
            btnExec.Click += Execute;
            btnPlusMinus.Click += ChangeSignOfNumber;
        }

        private void ChangeSignOfNumber(object sender, EventArgs e)
        {
            obslugaStringow.ChangeSignOfOperand();
            disp.Text = obslugaStringow.DisplayOperand();
        }

        private void Execute(object sender, EventArgs e)
        {
            obslugaStringow.Execute();
            disp.Text = obslugaStringow.Result;
        }

        private void BtnClr_Click(object sender, System.EventArgs e)
        {
            obslugaStringow = new StringManager();
            disp.Text = obslugaStringow.DisplayOperand();
        }

        private void AddDigitByNumeralBtn(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            obslugaStringow.AddDigitToOperand(btn.Text);
            disp.Text = obslugaStringow.DisplayOperand();
        }

        private void SwitchOperation(object sender, System.EventArgs e)
        {
            disp.Text = "0";
            Button btn = (Button)sender;
            obslugaStringow.ActionOperator = btn.Text;
        }
    }
}