using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace desktoptocc
{
    class NamedColor
    {
        public string name;
        public Color color;

        public NamedColor(string name, Color color)
        {
            this.name = name;
            this.color = color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int tick = 0;

            List<NamedColor> colorMap = new List<NamedColor>();

            //colorMap.Add(new NamedColor("0", Color.FromArgb(74, 58, 90)));
            //colorMap.Add(new NamedColor("1", Color.FromArgb(145, 33, 33)));
            //colorMap.Add(new NamedColor("2", Color.FromArgb(119, 80, 50)));
            //colorMap.Add(new NamedColor("3", Color.FromArgb(131, 84, 50)));
            //colorMap.Add(new NamedColor("4", Color.FromArgb(22, 23, 29)));
            //colorMap.Add(new NamedColor("5", Color.FromArgb(44, 46, 143)));
            //colorMap.Add(new NamedColor("6", Color.FromArgb(21, 119, 136)));
            //colorMap.Add(new NamedColor("7", Color.FromArgb(8, 10, 15)));
            //colorMap.Add(new NamedColor("8", Color.FromArgb(48, 51, 149)));
            //colorMap.Add(new NamedColor("9", Color.FromArgb(97, 60, 32)));
            //colorMap.Add(new NamedColor("10", Color.FromArgb(37, 23, 16)));
            //colorMap.Add(new NamedColor("11", Color.FromArgb(20, 21, 25)));
            //colorMap.Add(new NamedColor("12", Color.FromArgb(70, 73, 166)));
            //colorMap.Add(new NamedColor("13", Color.FromArgb(78, 52, 36)));
            //colorMap.Add(new NamedColor("14", Color.FromArgb(45, 47, 143)));
            //colorMap.Add(new NamedColor("15", Color.FromArgb(119, 75, 43)));
            //colorMap.Add(new NamedColor("16", Color.FromArgb(21, 143, 148)));
            //colorMap.Add(new NamedColor("17", Color.FromArgb(37, 149, 159)));
            //colorMap.Add(new NamedColor("18", Color.FromArgb(73, 77, 80)));
            //colorMap.Add(new NamedColor("19", Color.FromArgb(55, 58, 62)));
            //colorMap.Add(new NamedColor("20", Color.FromArgb(69, 77, 80)));
            //colorMap.Add(new NamedColor("21", Color.FromArgb(79, 100, 31)));
            //colorMap.Add(new NamedColor("22", Color.FromArgb(73, 91, 36)));
            //colorMap.Add(new NamedColor("23", Color.FromArgb(87, 91, 91)));
            //colorMap.Add(new NamedColor("24", Color.FromArgb(75, 82, 41)));
            //colorMap.Add(new NamedColor("25", Color.FromArgb(96, 118, 45)));
            //colorMap.Add(new NamedColor("26", Color.FromArgb(22, 160, 160)));
            //colorMap.Add(new NamedColor("27", Color.FromArgb(75, 93, 37)));
            //colorMap.Add(new NamedColor("28", Color.FromArgb(35, 136, 198)));
            //colorMap.Add(new NamedColor("29", Color.FromArgb(58, 43, 36)));
            //colorMap.Add(new NamedColor("30", Color.FromArgb(66, 72, 75)));
            //colorMap.Add(new NamedColor("31", Color.FromArgb(77, 186, 216)));
            //colorMap.Add(new NamedColor("32", Color.FromArgb(52, 168, 213)));
            //colorMap.Add(new NamedColor("33", Color.FromArgb(114, 109, 138)));
            //colorMap.Add(new NamedColor("34", Color.FromArgb(134, 106, 97)));
            //colorMap.Add(new NamedColor("35", Color.FromArgb(205, 209, 211)));
            //colorMap.Add(new NamedColor("36", Color.FromArgb(125, 125, 115)));
            //colorMap.Add(new NamedColor("37", Color.FromArgb(91, 164, 23)));
            //colorMap.Add(new NamedColor("38", Color.FromArgb(149, 149, 141)));
            //colorMap.Add(new NamedColor("39", Color.FromArgb(123, 188, 41)));
            //colorMap.Add(new NamedColor("40", Color.FromArgb(35, 136, 197)));
            //colorMap.Add(new NamedColor("41", Color.FromArgb(94, 169, 25)));
            //colorMap.Add(new NamedColor("42", Color.FromArgb(148, 148, 141)));
            //colorMap.Add(new NamedColor("43", Color.FromArgb(197, 90, 189)));
            //colorMap.Add(new NamedColor("44", Color.FromArgb(169, 48, 159)));
            //colorMap.Add(new NamedColor("45", Color.FromArgb(118, 190, 25)));
            //colorMap.Add(new NamedColor("46", Color.FromArgb(103, 117, 52)));
            //colorMap.Add(new NamedColor("47", Color.FromArgb(199, 79, 190)));
            //colorMap.Add(new NamedColor("48", Color.FromArgb(151, 89, 110)));
            //colorMap.Add(new NamedColor("49", Color.FromArgb(224, 97, 1)));
            //colorMap.Add(new NamedColor("50", Color.FromArgb(197, 76, 187)));
            //colorMap.Add(new NamedColor("51", Color.FromArgb(222, 123, 24)));
            //colorMap.Add(new NamedColor("52", Color.FromArgb(223, 140, 171)));
            //colorMap.Add(new NamedColor("53", Color.FromArgb(249, 128, 29)));
            //colorMap.Add(new NamedColor("54", Color.FromArgb(214, 101, 143)));
            //colorMap.Add(new NamedColor("55", Color.FromArgb(160, 82, 37)));
            //colorMap.Add(new NamedColor("56", Color.FromArgb(244, 119, 21)));
            //colorMap.Add(new NamedColor("57", Color.FromArgb(162, 78, 79)));
            //colorMap.Add(new NamedColor("58", Color.FromArgb(244, 181, 203)));
            //colorMap.Add(new NamedColor("59", Color.FromArgb(244, 169, 193)));
            //colorMap.Add(new NamedColor("60", Color.FromArgb(101, 32, 157)));
            //colorMap.Add(new NamedColor("61", Color.FromArgb(119, 71, 86)));
            //colorMap.Add(new NamedColor("62", Color.FromArgb(140, 51, 188)));
            //colorMap.Add(new NamedColor("63", Color.FromArgb(125, 52, 172)));
            //colorMap.Add(new NamedColor("64", Color.FromArgb(120, 40, 170)));
            //colorMap.Add(new NamedColor("65", Color.FromArgb(167, 53, 50)));
            //colorMap.Add(new NamedColor("66", Color.FromArgb(142, 33, 33)));
            //colorMap.Add(new NamedColor("67", Color.FromArgb(174, 45, 38)));
            //colorMap.Add(new NamedColor("68", Color.FromArgb(152, 94, 68)));
            //colorMap.Add(new NamedColor("69", Color.FromArgb(163, 40, 34)));
            //colorMap.Add(new NamedColor("70", Color.FromArgb(144, 62, 48)));
            //colorMap.Add(new NamedColor("71", Color.FromArgb(207, 213, 214)));
            //colorMap.Add(new NamedColor("72", Color.FromArgb(220, 222, 222)));
            //colorMap.Add(new NamedColor("73", Color.FromArgb(249, 255, 254)));
            //colorMap.Add(new NamedColor("74", Color.FromArgb(209, 177, 161)));
            //colorMap.Add(new NamedColor("75", Color.FromArgb(241, 243, 243)));
            //colorMap.Add(new NamedColor("76", Color.FromArgb(241, 175, 21)));
            //colorMap.Add(new NamedColor("77", Color.FromArgb(232, 195, 48)));
            //colorMap.Add(new NamedColor("78", Color.FromArgb(241, 175, 19)));
            //colorMap.Add(new NamedColor("79", Color.FromArgb(188, 135, 37)));
            //colorMap.Add(new NamedColor("80", Color.FromArgb(246, 188, 30)));



            int screenX = 0;
            int screenY = 0;
            int screenWidth = 1920;
            int screenHeight = 1080;

            int resizeWidth = 480/6;
            int resizeHeight = 270/6;

            int frameX = 0;
            int frameY = 0;
            int frameWidth = 480/6;
            int frameHeight = 270/6;

            int sleepFor = 1000;

            byte[] renderedBuffer = new byte[] { };

            Thread httpThread = new Thread(() =>
            {
                HttpListener server = new HttpListener();
                server.Prefixes.Add("http://127.0.0.1:8187/");
                server.Prefixes.Add("http://localhost:8187/");

                server.Start();

                while (true)
                {
                    HttpListenerContext context = server.GetContext();
                    Thread t = new Thread(() =>
                    {
                        try
                        {
                            var buffer = Encoding.UTF8.GetBytes(RenderFrame());
                            context.Response.StatusCode = 200;
                            context.Response.ContentEncoding = Encoding.UTF8;
                            context.Response.ContentLength64 = buffer.Length;
                            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                            context.Response.Close();
                            
                        } catch { }
                    });

                    t.SetApartmentState(ApartmentState.STA);
                    t.Start();
                }
            });

            httpThread.SetApartmentState(ApartmentState.STA);
            httpThread.Start();

         


            string RenderFrame()
            {

                Console.WriteLine("render start");
                Bitmap ss = GetSreenshot(screenX, screenY, screenWidth, screenHeight);
                Console.WriteLine("render 1");
                if (resizeWidth > 0 && resizeHeight > 0)
                {
                    ss = ResizeImage(ss, new Size(resizeWidth, resizeHeight));
                }
                Console.WriteLine("render 2");
                string result = "";
                int lastY = 0;
                for (int y = 0; y < frameHeight; y++)
                {
                    if (lastY != y)
                    {
                        result += "\n";
                        lastY = y;
                    }
                    for (int x = 0; x < frameWidth; x++)
                    {
                        //NamedColor color = NearestColor(ss.GetPixel(frameX + x, frameY + y), colorMap);
                        Color color = ss.GetPixel(frameX + x, frameY + y);
                        result += color.R + "," + color.G + "," + color.B + " ";
                    }
                }
                Console.WriteLine("render 3");

                Console.WriteLine("render end");

                return result;
            }


            Bitmap GetSreenshot(int x, int y, int w, int h)
            {
                Bitmap bm = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(bm);
                g.CopyFromScreen(x, y, 0, 0, bm.Size);
                return bm;
            }

            Bitmap ResizeImage(Bitmap imgToResize, Size size)
            {
                try
                {
                    Bitmap b = new Bitmap(size.Width, size.Height);
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
                        g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Bitmap could not be resized");
                    return imgToResize;
                }
            }


            NamedColor NearestColor(Color needle, List<NamedColor> colors)
            {
                NamedColor result = new NamedColor("TEMP", Color.Transparent);

                double distanceSq;
                double minDistanceSq = double.MaxValue;
                NamedColor currentColor;
                for (int i = 0; i < colors.Count; i++)
                {
                    currentColor = colors[i];

                    distanceSq =
                        Math.Pow(needle.R - currentColor.color.R, 2) +
                        Math.Pow(needle.G - currentColor.color.G, 2) +
                        Math.Pow(needle.B - currentColor.color.B, 2);

                    if (distanceSq < minDistanceSq)
                    {
                        minDistanceSq = distanceSq;
                        result = currentColor;
                    }
                }

                return result;
            }

            Thread.Sleep(-1);

        }


    }
}
