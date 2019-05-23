using germsVage;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gVl
{
    public static class DataSource
    {
        public static  ObservableCollection<KeyValuePair<double, double>> Plot { get; set; }
        private static readonly Gva _lst = new Gva();

        // _lst.stepByage(startEnd, inc, upperLim);// Populate the list
        public static void StepByage(double start, double inc, double upperVal)
        {
            _lst.LIST.Clear();
            _lst.StepByage(start, inc, upperVal);

            if (Plot == null)
                Plot = new ObservableCollection<KeyValuePair<double, double>>();
            else
                Plot.Clear();

            foreach (var x in _lst.LIST)
            {
                KeyValuePair<double, double> kvp = new KeyValuePair<double, double>(x.Age, x.Ger);
                Plot.Add(kvp);
            }
        }
    }
}
