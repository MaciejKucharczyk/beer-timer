using Microsoft.AspNetCore.Components.Web;


namespace beer_timer.Models
{
    public class BeerTimer
    {
        public BeerTimer(int sec, int tens)
        {
            this.Sec = sec;
            this.Tens = tens;   
        }
        public int Sec { get; set; }
        public int Tens { get; set; }


        //static TimeSpan czas = new TimeSpan();

        ///*
        //public event EventHandler Clicked;

        //protected virtual void OnClicked(EventArgs e)
        //{
        //    Clicked?.Invoke(this, e);
        //}
        //*/

        //private void textContainer_rtb_KeyDown(object sender, KeyboardEventArgs e)
        //{
        //    //if (e.KeyChar == Keys.Space)
        //}

        //void Main(string[] args)
        //{

        //}
    }


}
