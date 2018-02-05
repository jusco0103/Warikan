using System;

using UIKit;

namespace Warikan
{
    public partial class ViewController : UIViewController
    {
        partial void WarikanButton_TouchUpInside(UIButton sender)
        {

            //入力フォームが空欄だった場合のSystem.FormatException対策
            if (KingakuForm.Text == "")
            {
                KingakuForm.Text = "0";
            }
            if (NinzuForm.Text == "")
            {
                NinzuForm.Text = "0";
            }

            //変数宣言
            int Kingaku;
            int Ninzu;

            //入力フォームの値(.Text)をintに変換して格納
            Kingaku = Convert.ToInt32(KingakuForm.Text);
            Ninzu = Convert.ToInt32(NinzuForm.Text);

            //金額が0円の場合はアラート表示
            if (Kingaku == 0)
            {
                var ac = UIAlertController.Create("アラート", "合計金額又は、人数が未入力です。", UIAlertControllerStyle.Alert);
                var action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                ac.AddAction(action);
                PresentViewController(ac, true, null);
            }

            //人数が１人以下の場合はアラート表示
            else if (Ninzu <= 1)
            {
                var ac = UIAlertController.Create("アラート", "人数は２名以上入力してください。", UIAlertControllerStyle.Alert);
                var action = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
                ac.AddAction(action);
                PresentViewController(ac, true, null);
            }

            //計算処理＆stringに変換して格納
            else
            {
                double Kekka1 = Kingaku / Ninzu;
                Kekka1 = Math.Ceiling(Kekka1 * 0.01f) * 100;
                string Kekka2 = Kekka1.ToString();
                //ラベルに表示
                KekkaLabel.Text = Kekka2;
            }
         }

        partial void ResetButton_TouchUpInside(UIButton sender)
        {
            KingakuForm.Text = "";
            NinzuForm.Text = "";
         }
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
