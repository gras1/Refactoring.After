using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGV
{
    public partial class ChartSingleCompareOrig : Form
    {
        private string _displayType;

        private int _chartType;

        private const int CHART_TYPE_BAR = 150;

        private Bitmap _drawArea;

        public ChartSingleCompareOrig()
        {
            InitializeComponent();
        }

        public void ShowChart(int chartType, string displayType, bool shouldShowDialog)
        {
            this._chartType = chartType;
            this._displayType = displayType;
            _drawArea = new Bitmap(this.ClientRectangle.Width,
                                  this.ClientRectangle.Height,
                                  System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            InitializeDrawArea();
            RenderChart();
            if (shouldShowDialog)
            {
                this.ShowDialog();
            }
        }

        private void InitializeDrawArea()
        {
            var g = Graphics.FromImage(_drawArea);
            g.Clear(Color.LightYellow);
        }

        private void ChartSingleCompareOrig_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImage(_drawArea, 0, 0, _drawArea.Width, _drawArea.Height);
        }

        private void RenderChart()
        {
            var g = Graphics.FromImage(_drawArea);
            g.Clear(Color.LightYellow);
            var chart = _chartType == CHART_TYPE_BAR ? (IChart) new BarChart() : new PieChart();
            chart.RenderBackground(_displayType, g);
            var data = chart.GetData(_displayType);
            chart.Render(_displayType, g, data);
            InvalidateIfNeeded(g, data);
        }

        private void InvalidateIfNeeded(Graphics g, Data data)
        {
            try
            {
                if (ShouldInvalidate(g, data))
                {
                    this.Invalidate();
                }
            }
            catch (ArgumentException ex)
            {
                this.Invalidate();
            }
        }

        private static bool ShouldInvalidate(Graphics g, Data data)
        {
            return !(g.DpiX == 300) ||
                    g != null && (data.otherData.Length > 20 || data.otherData.Length < 5) &&
                    (data.data == null || !data.data.StartsWith("hold"));
        }
    }
}