using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGV;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;

namespace MsTest
{

    [TestClass]
    public class ChartSmartTest
    {
        [TestMethod]
        public void TestMainWindow()
        {
            byte[] generatedImgData;
            string approvedImgString;

            var main = new frmMain();
            main.Show();

            using (var generatedBitmap = new Bitmap(main.Width, main.Height))
            {
                main.DrawToBitmap(generatedBitmap, new Rectangle(0, 0, main.Width, main.Height));
                using (var generatedBitmapStream = new MemoryStream())
                {
                    generatedBitmap.Save(generatedBitmapStream, ImageFormat.Png);
                    generatedImgData = generatedBitmapStream.GetBuffer();
                }
            }
            main.Close();
            main.Dispose();

            var assembly = Assembly.GetExecutingAssembly();
            using (var approvedStream = assembly.GetManifestResourceStream("ChartSmart.Test.ChartSmartTest.TestMainWindow.approved.txt"))
            {
                using (var reader = new StreamReader(approvedStream))
                {
                    approvedImgString = reader.ReadToEnd();
                }
            }

            var generatedImgStringSb = new StringBuilder();
            foreach (var imgByte in generatedImgData)
            {
                generatedImgStringSb.Append(imgByte + ",");
            }
            var generatedImgString = generatedImgStringSb.ToString();

            //File.WriteAllText(@"C:\Projects\DesignPatternsAndSoftwareCraftmanship\DesignPrinciples\Refactoring\After\ChartSmart.Test\ChartSmartTest.TestMainWindow.txt", generatedImgString);

            Assert.IsTrue(approvedImgString == generatedImgString);
        }

        [TestMethod]
        public void TestBarChartWindow()
        {
            frmMain main = new frmMain();
            main.Show();
            ChartSingleCompareOrig chart = main.LaunchChart(150, "rpfll", false);
            chart.Show();

            byte[] generatedImgData;
            string approvedImgString;


            using (var generatedBitmap = new Bitmap(chart.Width, chart.Height))
            {
                chart.DrawToBitmap(generatedBitmap, new Rectangle(0, 0, chart.Width, chart.Height));
                using (var generatedBitmapStream = new MemoryStream())
                {
                    generatedBitmap.Save(generatedBitmapStream, ImageFormat.Png);
                    generatedImgData = generatedBitmapStream.GetBuffer();
                }
            }
            chart.Close();
            chart.Dispose();
            main.Close();
            main.Dispose();

            var assembly = Assembly.GetExecutingAssembly();
            using (
                var approvedStream =
                    assembly.GetManifestResourceStream("ChartSmart.Test.ChartSmartTest.TestBarChartWindow.approved.txt")
                )
            {
                using (var reader = new StreamReader(approvedStream))
                {
                    approvedImgString = reader.ReadToEnd();
                }
            }

            var generatedImgStringSb = new StringBuilder();
            foreach (var imgByte in generatedImgData)
            {
                generatedImgStringSb.Append(imgByte + ",");
            }
            var generatedImgString = generatedImgStringSb.ToString();

            //File.WriteAllText(@"C:\Projects\DesignPatternsAndSoftwareCraftmanship\DesignPrinciples\Refactoring\After\ChartSmart.Test\ChartSmartTest.TestBarChartWindow.txt", generatedImgString);

            Assert.IsTrue(approvedImgString == generatedImgString);
        }

        [TestMethod]
        public void TestBarChartCompareWindow()
        {
            frmMain main = new frmMain();
            main.Show();
            ChartSingleCompareOrig chart = main.LaunchChart(150, "splitdisplay", false);
            chart.Show();

            byte[] generatedImgData;
            string approvedImgString;


            using (var generatedBitmap = new Bitmap(chart.Width, chart.Height))
            {
                chart.DrawToBitmap(generatedBitmap, new Rectangle(0, 0, chart.Width, chart.Height));
                using (var generatedBitmapStream = new MemoryStream())
                {
                    generatedBitmap.Save(generatedBitmapStream, ImageFormat.Png);
                    generatedImgData = generatedBitmapStream.GetBuffer();
                }
            }
            chart.Close();
            chart.Dispose();
            main.Close();
            main.Dispose();

            var assembly = Assembly.GetExecutingAssembly();
            using (
                var approvedStream =
                    assembly.GetManifestResourceStream(
                        "ChartSmart.Test.ChartSmartTest.TestBarChartCompareWindow.approved.txt"))
            {
                using (var reader = new StreamReader(approvedStream))
                {
                    approvedImgString = reader.ReadToEnd();
                }
            }

            var generatedImgStringSb = new StringBuilder();
            foreach (var imgByte in generatedImgData)
            {
                generatedImgStringSb.Append(imgByte + ",");
            }
            var generatedImgString = generatedImgStringSb.ToString();

            //File.WriteAllText(@"C:\Projects\DesignPatternsAndSoftwareCraftmanship\DesignPrinciples\Refactoring\After\ChartSmart.Test\ChartSmartTest.TestBarChartCompareWindow.txt", generatedImgString);

            Assert.IsTrue(approvedImgString == generatedImgString);
        }

        [TestMethod]
        public void TestPieChartWindow()
        {
            frmMain main = new frmMain();
            main.Show();
            ChartSingleCompareOrig chart = main.LaunchChart(712, "rpfll", false);
            chart.Show();

            byte[] generatedImgData;
            string approvedImgString;


            using (var generatedBitmap = new Bitmap(chart.Width, chart.Height))
            {
                chart.DrawToBitmap(generatedBitmap, new Rectangle(0, 0, chart.Width, chart.Height));
                using (var generatedBitmapStream = new MemoryStream())
                {
                    generatedBitmap.Save(generatedBitmapStream, ImageFormat.Png);
                    generatedImgData = generatedBitmapStream.GetBuffer();
                }
            }
            chart.Close();
            chart.Dispose();
            main.Close();
            main.Dispose();

            var assembly = Assembly.GetExecutingAssembly();
            using (
                var approvedStream =
                    assembly.GetManifestResourceStream("ChartSmart.Test.ChartSmartTest.TestPieChartWindow.approved.txt")
                )
            {
                using (var reader = new StreamReader(approvedStream))
                {
                    approvedImgString = reader.ReadToEnd();
                }
            }

            var generatedImgStringSb = new StringBuilder();
            foreach (var imgByte in generatedImgData)
            {
                generatedImgStringSb.Append(imgByte + ",");
            }
            var generatedImgString = generatedImgStringSb.ToString();

            //File.WriteAllText(@"C:\Projects\DesignPatternsAndSoftwareCraftmanship\DesignPrinciples\Refactoring\After\ChartSmart.Test\ChartSmartTest.TestPieChartWindow.txt", generatedImgString);

            Assert.IsTrue(approvedImgString == generatedImgString);
        }

        [TestMethod]
        public void TestPieChartCompareWindow()
        {
            frmMain main = new frmMain();
            main.Show();
            ChartSingleCompareOrig chart = main.LaunchChart(712, "splitdisplay", false);
            chart.Show();

            byte[] generatedImgData;
            string approvedImgString;


            using (var generatedBitmap = new Bitmap(chart.Width, chart.Height))
            {
                chart.DrawToBitmap(generatedBitmap, new Rectangle(0, 0, chart.Width, chart.Height));
                using (var generatedBitmapStream = new MemoryStream())
                {
                    generatedBitmap.Save(generatedBitmapStream, ImageFormat.Png);
                    generatedImgData = generatedBitmapStream.GetBuffer();
                }
            }
            chart.Close();
            chart.Dispose();
            main.Close();
            main.Dispose();

            var assembly = Assembly.GetExecutingAssembly();
            using (
                var approvedStream =
                    assembly.GetManifestResourceStream(
                        "ChartSmart.Test.ChartSmartTest.TestPieChartCompareWindow.approved.txt"))
            {
                using (var reader = new StreamReader(approvedStream))
                {
                    approvedImgString = reader.ReadToEnd();
                }
            }

            var generatedImgStringSb = new StringBuilder();
            foreach (var imgByte in generatedImgData)
            {
                generatedImgStringSb.Append(imgByte + ",");
            }
            var generatedImgString = generatedImgStringSb.ToString();

            //File.WriteAllText(@"C:\Projects\DesignPatternsAndSoftwareCraftmanship\DesignPrinciples\Refactoring\After\ChartSmart.Test\ChartSmartTest.TestPieChartCompareWindow.txt", generatedImgString);

            Assert.IsTrue(approvedImgString == generatedImgString);
        }
    }
}