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

        public const string header = "XAMARIN";

        public MainPage()
        {
            InitializeComponent();

            //for (int i = 1; i < 17; i++)
            //{
            //    Label label = new Label
            //    {
            //        Text = "Метка " + i,
            //        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            //    };
            //    stackLayout.Children.Add(label);
            //}
            //ScrollView scrollView = new ScrollView();
            //scrollView.Content = stackLayout;
            ////Content = scrollView;
            ///
            int p = 0;
            for (int i = 0; i < 18; i++)
            {
                if (i > 12) { p++; }   
                for (int j = 0; j < 18; j++)
                {
                    if ((i < 5)&&(i!=0))
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
                    else if ((i == 5)||(i==12))
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
                        mygrid.Children.Add(new BoxView { Color = Color.Yellow}, j, i);
                    }
                }
            }
            mygrid.Children.Add(new BoxView { Color = Color.Black }, 0, 2,0,1);
        }

        //private void mybut1_Click(object sender, EventArgs e)
        //{
        //   // mybut1.Text = "Ура!!!";
        //}

    }
}
