using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastReport.DataVisualization.Charting;

namespace pr1
{
    class Line
    {
        public Line(double X1, double Y1, double X2, double Y2) { this.X1 = X1;this.Y1 = Y1;this.X2 = X2;this.Y2 = Y2; }
        private  double _X1;
        private  double _Y1;
        private  double _X2;
        private  double _Y2;
        public  double X1
        {
            set { _X1 = value; }
            get { return _X1; }
        }
        public  double Y1
        {
            set { _Y1 = value; }
            get { return _Y1; }
        }
        public  double X2
        {
            set { _X2 = value; }
            get { return _X2; }
        }
        public  double Y2
        {
            set { _Y2 = value; }
            get { return _Y2; }
        }
    }
    
}