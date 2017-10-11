using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace MVVM.ViewModel
{
    class MainViewModel
    {
        public List<string> Shapes { get; set; }

        public string SelectedItem { get; set; }
        public MainViewModel()
        {
            Shapes = new List<string>() { "Rechteck", "Kreis", "Quadrat", "Parallelogram", "Rechtwinkeliges Dreieck"};
            SelectedItem = "Parallelogram";

            DispatcherTimer t = new DispatcherTimer();
            t.Interval = new TimeSpan(0, 0, 3);
            t.Tick += T_Tick;
            t.Start();

        }

        private void T_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
