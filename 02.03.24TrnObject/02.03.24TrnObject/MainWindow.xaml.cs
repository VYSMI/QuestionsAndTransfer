using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace _02._03._24TrnObject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int countZ = 0;
        bool canMove = false;
        Point offsetPoint = new Point(0, 0);
        private void FF_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            canMove = true;
            countZ++;
            FrameworkElement ffElement = (FrameworkElement)sender;
            Grid.SetZIndex(ffElement, countZ);
            Point posCursor = e.MouseDevice.GetPosition(this);
            offsetPoint = new Point(posCursor.X - Canvas.GetLeft(ffElement), posCursor.Y - Canvas.GetTop(ffElement));
            e.MouseDevice.Capture(ffElement);
        }
        private void FF_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove == true)
            {
                FrameworkElement ffElement = (FrameworkElement)sender;
                if (e.MouseDevice.Captured == ffElement)
                {
                    //если да, то осуществляем перемещение элемента:
                    Point p = e.MouseDevice.GetPosition(this);
                    Canvas.SetLeft(ffElement, p.X - offsetPoint.X);
                    Canvas.SetTop(ffElement, p.Y - offsetPoint.Y);
                }
            }                                      
        }
        private void FF_MouseUp(object sender, MouseButtonEventArgs e)
        {
            canMove = false;
            e.MouseDevice.Capture(null);
        }       
    }
}
        
    
    
