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

namespace Astar.uctrl
{
    /// <summary>
    /// Interaction logic for cell.xaml
    /// </summary>
    public partial class cell : UserControl
    {
        /// <summary>
        /// value manager index
        /// </summary>
        public int index = 0;
        private int lim = 100; 
        public cell()
        {
            InitializeComponent();
            index = 0;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(_this.Background==Brushes.White)
            {
                _this.Background = (Brush)new BrushConverter().ConvertFromString("#FF494949");
                index = 0;
            }else
            {
                _this.Background = Brushes.White;
                index = lim;
            }
        }
        public void light()
        {
            _this.Background = Brushes.White;
            index = lim;
        }
        public void dark()
        {
            _this.Background = (Brush)new BrushConverter().ConvertFromString("#FF494949");
            index = 0;
        }
    }
    
}
