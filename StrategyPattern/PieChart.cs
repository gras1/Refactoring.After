using System.Drawing;

namespace SGV
{
    public class PieChart : DisplayType, IChart
    {
        public void Render(string displayType, Graphics g, Data data)
        {
            var stringFormat = new StringFormat();
            RectangleF boundingRect;

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            if (data.otherData != "")
            {
                boundingRect = new RectangleF(50, 100, 320, 320);
                g.DrawString(data.otherData, new Font("Cooper Black", 40), new SolidBrush(Color.White), boundingRect, stringFormat);
            }
            else
            {
                boundingRect = new RectangleF(50, 100, 160, 160);
                g.DrawString(data.someOtherDataObject, new Font("Cooper Black", 20), new SolidBrush(Color.White), boundingRect, stringFormat);
            }

            g.Dispose();
        }

        public Data GetData(string displayType)
        {
            Data data = new Data();
            if (displayType == FULL)
            {
                data.otherData = "Pie Data\nLarge";
            }
            else
            {
                data.someOtherDataObject = "Pie Data\nSmall";
            }
            return data;
        }

        public void RenderBackground(string displayType, Graphics g)
        {
            SolidBrush brush;
            if (displayType != FULL)
            {
                brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 50, 100, 160, 160);
            }
            else
            {
                brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 50, 100, 320, 320);
            }
            brush.Dispose();
        }
    }
}