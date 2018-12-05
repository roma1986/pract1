using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pract1
{

    public partial class MainPage : ContentPage
    {
        public static double staticVar = 10;

        public MainPage()
        {
            InitializeComponent();
        }
        public void smileBoxViev()
        {
            int p = 0;
            for (int i = 0; i < 18; i++)
            {
                if (i > 12) { p++; }
                for (int j = 0; j < 18; j++)
                {
                    if ((i < 5) && (i != 0))
                    {
                        if ((j > 4 - i) && (j < 13 + i))
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Yellow }, j, i);
                        }
                        else
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Green }, j, i);
                        }
                    }
                    else if ((i == 5) || (i == 12))
                    {
                        if ((j > 0) && (j < 17))
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Yellow }, j, i);
                        }
                        else
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Green }, j, i);
                        }
                    }
                    else if ((i == 0) || (i == 17))
                    {
                        if ((j > 5) && (j < 12))
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Yellow }, j, i);
                        }
                        else
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Green }, j, i);
                        }
                    }
                    else if ((i > 12) && (i != 17))
                    {
                        if ((j > 0 + p - 1) && (j < 17 - (p - 1)))
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Yellow }, j, i);
                        }
                        else
                        {
                            mygrid.Children.Add(new BoxView { Color = Color.Green }, j, i);
                        }
                    }
                    else
                    {
                        mygrid.Children.Add(new BoxView { Color = Color.Yellow }, j, i);
                    }
                }
            }
            BoxView BlackBox11 = new BoxView { Color = Color.Black };
            mygrid.Children.Add(BlackBox11, 4, 5);
            Grid.SetColumnSpan(BlackBox11, 3);

            BoxView BlackBox12 = new BoxView { Color = Color.Black };
            mygrid.Children.Add(BlackBox12, 5, 4);
            Grid.SetRowSpan(BlackBox12, 3);

            BoxView BlackBox21 = new BoxView { Color = Color.Black };
            mygrid.Children.Add(BlackBox21, 11, 5);
            Grid.SetColumnSpan(BlackBox21, 3);

            BoxView BlackBox22 = new BoxView { Color = Color.Black };
            mygrid.Children.Add(BlackBox22, 12, 4);
            Grid.SetRowSpan(BlackBox22, 3);

            BoxView BlackBoxr = new BoxView { Color = Color.Black };
            mygrid.Children.Add(BlackBoxr, 6, 10);
            Grid.SetColumnSpan(BlackBoxr, 6);

            mygrid.Children.Add(new BoxView { Color = Color.Black }, 5, 11);
            mygrid.Children.Add(new BoxView { Color = Color.Black }, 4, 12);
            mygrid.Children.Add(new BoxView { Color = Color.Black }, 12, 11);
            mygrid.Children.Add(new BoxView { Color = Color.Black }, 13, 12);

            BoxView BlackBoxpit = new BoxView { Color = Color.Pink};
            mygrid.Children.Add(BlackBoxpit, 14, 0);
            Grid.SetColumnSpan(BlackBoxpit, 2);
            Grid.SetRowSpan(BlackBoxpit, 3);
        }
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            smileBoxViev();
            butSmile.IsEnabled = false;
        }
        //private void mybut1_Click(object sender, EventArgs e)
        //{
        //   // mybut1.Text = "Ура!!!";
        //}

    }
}
