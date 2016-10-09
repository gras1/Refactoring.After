using System.Drawing;

namespace SGV
{
    public interface IChart
    {
        void RenderBackground(string displayType, Graphics g);

        void Render(string displayType, Graphics g, Data data);

        Data GetData(string displayType);
    }
}
