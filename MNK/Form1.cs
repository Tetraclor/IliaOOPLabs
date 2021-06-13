using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex.Solvers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IliaOOPLabs
{
    public partial class Form1 : Form
    {
      
        public FuncInfo PointFuncInfo;
        public FuncInfo AproxFuncInfo;
        public ChartInfo ChartInfo;
        public Action InitPoints;
        public Action RefreshPoints;

        public void InitVariant11()
        {
            var x = new double[] { 2, 4, 6, 8, 10, 12, 14, 16 };
            var y = new double[] { 0.035, 0.09, 0.147, 0.2, 0.24, 0.28, 0.31, 0.34 };

            var funcPoints = x.Zip(y, (a, b) => new Point(a, b))
             .ToList();

            var xName = "h";
            var yName = "R";

            PointFuncInfo = new FuncInfo()
            {
                Points = funcPoints,
                XName = xName,
                YName = yName,
            };
        }

        public void RefreshVariant11()
        {
            var aproxFunc = GenerateQuadraticAproxFunc(PointFuncInfo.Points);
            var aproxPoints = GeneratePoints(PointFuncInfo.MinX, PointFuncInfo.MaxX, 0.1, aproxFunc);

            AproxFuncInfo = new FuncInfo()
            {
                Points = aproxPoints,
            };
        }

        public void InitVariant13()
        {
            var x = new double[] { 1.2, 1.4, 1.6, 1.8, 2, 2.2, 2.4, 2.6, 2.8, 3 };
            var y = new double[] { 1.5, 2.7, 3.9, 5.5, 7.1, 9.1, 11.1, 12.9, 15.5, 17.9 };

            PointFuncInfo = new FuncInfo()
            {
                Points = x.Zip(y, (a, b) => new Point(a, b)).ToList(),
                XName = "x",
                YName = "Y",
            };
        }

        public void RefreshVariant13()
        {
            var aproxFunc = GeneretaTripleAproxFunc(PointFuncInfo.Points);
            var aproxPoints = GeneratePoints(PointFuncInfo.MinX, PointFuncInfo.MaxX, 0.1, aproxFunc);

            AproxFuncInfo = new FuncInfo()
            {
                Points = aproxPoints,
            };
        }


        public Form1()
        {
            InitializeComponent();

            InitPoints = InitVariant13;
            RefreshPoints = RefreshVariant13;

            InitPoints();
            RefreshPoints();
            InitGrid();
            InitChart();
            RefreshChart();
        }

        public void InitGrid() 
        {
            dataGridView1.DataSource = PointFuncInfo.Points;
            dataGridView1.Columns["X"].HeaderText = PointFuncInfo.XName;
            dataGridView1.Columns["Y"].HeaderText = PointFuncInfo.YName;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        public void InitChart()
        {
            ChartInfo = new ChartInfo(chart1);
        }

        public void RefreshChart()
        {
            chart1.ChartAreas[0].AxisX.Minimum = PointFuncInfo.MinX;
            chart1.ChartAreas[0].AxisX.Maximum = PointFuncInfo.MaxX;
            chart1.ChartAreas[0].AxisY.Minimum = PointFuncInfo.MinY;
            chart1.ChartAreas[0].AxisY.Maximum = PointFuncInfo.MaxY;

            chart1.Series["Points"].ChartType = SeriesChartType.Point;
            chart1.Series["Points"].Points.DataBindXY(PointFuncInfo.X, PointFuncInfo.Y);

            ChartInfo.AproxFuncSeries.ChartType = SeriesChartType.Line;
            ChartInfo.AproxFuncSeries.Points.DataBindXY(AproxFuncInfo.X, AproxFuncInfo.Y);
        }


        public double CalcError(List<Point> points, Func<double, double> func)
        {
            var realY = points.Select(v => v.Y).ToArray();
            var predictY = points.Select(v => func(v.X)).ToArray();
            return realY.Zip(predictY, (a, b) => a - b).Sum();
        }

        public Func<double, double> GenerateQuadraticAproxFunc(List<Point> points)
        {
            var n = points.Count;
            var x = points.Select(v => v.X).ToArray();
            var y = points.Select(v => v.Y).ToArray();
            var x2 = PowArray(x, 2);
            var x3 = PowArray(x, 3);
            var x4 = PowArray(x, 4);
            var xy = x.Zip(y, (a_, b_) => a_ * b_).ToArray();
            var x2y = PowArray(x, 2).Zip(y, (a_, b_) => a_ * b_).ToArray();

            var left = Matrix<double>.Build.DenseOfArray(new double[,] {
                { x4.Sum(), x3.Sum(), x2.Sum()},
                { x3.Sum(), x2.Sum(), x.Sum()},
                { x2.Sum(), x.Sum() , n}
            });

            var right = Vector<double>.Build.Dense(new double[] { x2y.Sum(), xy.Sum(), y.Sum()});

            var abc = left.Solve(right);
            var a = abc[0];
            var b = abc[1];
            var c = abc[2];

            Func<double, double> func = (xValue) => a * xValue * xValue + b * xValue + c;

            resultLabel.Text = $"a = {a}\nb = {b}\nc = {c}\nError = {CalcError(points, func)}";

            return func;
        }

        public Func<double, double> GeneretaTripleAproxFunc(List<Point> points)
        {
            var n = points.Count;
            var x = points.Select(v => v.X).ToArray();
            var y = points.Select(v => v.Y).ToArray();
            var x2 = PowArray(x, 2);
            var x3 = PowArray(x, 3);
            var x4 = PowArray(x, 4);
            var x5 = PowArray(x, 5);
            var x6 = PowArray(x, 6);
            var xy = x.Zip(y, (a_, b_) => a_ * b_).ToArray();
            var x2y = x2.Zip(y, (a_, b_) => a_ * b_).ToArray();
            var x3y = x3.Zip(y, (a_, b_) => a_ * b_).ToArray();

            var left = Matrix<double>.Build.DenseOfArray(new double[,] {
                { x6.Sum(), x5.Sum(), x4.Sum(), x3.Sum()},
                { x5.Sum(), x4.Sum(), x3.Sum(), x2.Sum()},
                { x4.Sum(), x3.Sum(), x2.Sum() , x.Sum()},
                { x3.Sum(), x2.Sum() , x.Sum(), n}
            });

            var right = Vector<double>.Build.Dense(new double[] { x3y.Sum(), x2y.Sum(), xy.Sum(), y.Sum() });

            var abcd = left.Solve(right);
            var a = abcd[0];
            var b = abcd[1];
            var c = abcd[2];
            var d = abcd[3];

            Func<double, double> func = (x_) => a * x_*x_*x_ +  b * x_*x_ + c * x_ + d;

            resultLabel.Text = $"a = {a}\nb = {b}\nc = {c}\nd = {d}\nError = {CalcError(points, func)}";

            return func;
        }
        public double[] PowArray(double[] values, int pow)
        {
            return values.Select(v => Math.Pow(v, pow)).ToArray();
        }

        public List<Point> GeneratePoints(double minX, double maxX, double step, Func<double, double> func)
        {
            var result = new List<Point>();
            maxX += step;
            for (var x = minX; x < maxX; x += step)
            {
                result.Add(new Point(x, func(x)));
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshPoints();
            RefreshChart();
        }
    }

    public class ChartInfo
    {
        public Chart Chart;
        public Series PointSeries => Chart.Series["Points"];
        public Series AproxFuncSeries => Chart.Series["AproxFunc"];
        public ChartInfo(Chart chart)
        {
            this.Chart = chart;
            chart.Series.Clear();
            chart.Series.Add("Points");
            chart.Series.Add("AproxFunc");
        }      
    }

    public class FuncInfo
    {
        public List<Point> Points = new List<Point>();
        public double[] X => Points.Select(v => v.X).ToArray();
        public double[] Y => Points.Select(v => v.Y).ToArray();
        public double MinX => X.Min();
        public double MinY => Y.Min();
        public double MaxX => X.Max();
        public double MaxY => Y.Max();
        public string XName;
        public string YName;
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {

        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

