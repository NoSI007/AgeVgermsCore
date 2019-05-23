// (c) Khaled A Alwan .
// All other rights reserved.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace germsVage
{
    /// <summary>
    /// Make a collection for binding, 
    /// </summary>
    public class Gva
    {
        /// <summary>
        /// The collection List
        /// <see cref="GVaitem"/>
        /// </summary>
        private ObservableCollection<GVaitem> _list = new ObservableCollection<GVaitem>();
        /// <summary>
        /// The props to Access the above List
        /// </summary>
        public ObservableCollection<GVaitem> LIST
        {
            get { return _list; }
            set { _list = value; }
        }
        /// <summary>
        /// populate the list with values, using the given parameters
        /// </summary>
        /// <param name="start">The Start Value</param>
        /// <param name="inc">The Age increment in years</param>
        /// <param name="upperVal">How many values are required.</param>
        public void StepByage(double start, double inc, double upperVal)
        {
            LIST.Clear();
            double age = start;

            for (double i = start; i <= upperVal; i += inc)
            {
                GVaitem x = new GVaitem();
                x.SetGer(age);
                LIST.Add(x);
                age += inc;
            }
        }

        /// <summary>
        /// populate the list by germs
        /// </summary>
        /// <param name="startEnd">The Start Value, That way a reminder on the starting to germs.</param>
        /// <param name="inc">the increment before the next value</param>
        /// <param name="Steps">The number of the steps required.</param>
        public void StepByger(double startEnd, double inc, int Steps)
        {
            LIST.Clear();
            Double ger = startEnd;// start the end.. war on germs
            for (int i = 0; i < Steps; i++)
            {
                GVaitem x = new GVaitem();
                x.SetAge(ger);
                LIST.Add(x);
                ger += inc;
            }
        }
    }
}
