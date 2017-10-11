using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
