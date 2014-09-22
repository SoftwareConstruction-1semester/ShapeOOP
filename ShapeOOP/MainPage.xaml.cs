using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Shapes;

namespace ShapeOOP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //my variables
        List<MyEllipse> ellipses = new List<MyEllipse>(); 

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // create MyEllipse object
            MyEllipse myEllipse = new MyEllipse(200, 150, 500, 300, Colors.RoyalBlue);
            ellipses.Add(myEllipse);

            Ellipse ellipse = new Ellipse();
            ellipse.Width = myEllipse.width;
            ellipse.Height = myEllipse.height;
            ellipse.Margin = new Thickness(myEllipse.positionX, myEllipse.positionY,0,0);
            ellipse.Fill = new SolidColorBrush(myEllipse.color);
     
            MyGrid.Children.Add(ellipse);
        }

        
    }
}
