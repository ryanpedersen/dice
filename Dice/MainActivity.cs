using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using System.Threading.Tasks;

namespace Dice
{
    [Activity(Label = "Dice", MainLauncher = true, Icon = "@drawable/DiceIcon")]
    public class MainActivity : Activity
    {
        private ImageView Dice1;
        private ImageView Dice2;
        private Button button;
        int w;

        private static Random rand1 = new Random();

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.MyButton);

            Dice1 = FindViewById<ImageView>(Resource.Id.diceOne);
            Dice2 = FindViewById<ImageView>(Resource.Id.diceTwo);

            button.Click += Button_Click;

            Dice1.Click += Button_Click;
            Dice2.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int d1 = rand1.Next(1, 6);
            int d2 = rand1.Next(1, 6);

            switch (d1)
            {
                case 1:
                    Dice1.SetImageResource(Resource.Drawable.dice1);
                    break;
                case 2:
                    Dice1.SetImageResource(Resource.Drawable.dice2);
                    break;
                case 3:
                    Dice1.SetImageResource(Resource.Drawable.dice3);
                    break;
                case 4:
                    Dice1.SetImageResource(Resource.Drawable.dice4);
                    break;
                case 5:
                    Dice1.SetImageResource(Resource.Drawable.dice5);
                    break;
                case 6:
                    Dice1.SetImageResource(Resource.Drawable.dice6);
                    break;
                default:
                    throw new ArgumentException("number");
            }

            switch (d2)
            {
                case 1:
                    Dice2.SetImageResource(Resource.Drawable.dice1);
                    break;
                case 2:
                    Dice2.SetImageResource(Resource.Drawable.dice2);
                    break;
                case 3:
                    Dice2.SetImageResource(Resource.Drawable.dice3);
                    break;
                case 4:
                    Dice2.SetImageResource(Resource.Drawable.dice4);
                    break;
                case 5:
                    Dice2.SetImageResource(Resource.Drawable.dice5);
                    break;
                case 6:
                    Dice2.SetImageResource(Resource.Drawable.dice6);
                    break;
                default:
                    throw new ArgumentException("number");
            }

            var metrics = Resources.DisplayMetrics;

           // button.Text = string.Format("{0} {1} {2} values!", widthInDp, heightInDp, w) ;
        }
    }
}

