using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using Rainmeter;

namespace MousePositionPlugin
{
    public class Measure
    {
        private string type;

        internal void Reload(API api, ref double maxValue)
        {
            type = api.ReadString("MeasureType", "MouseX").ToLowerInvariant();
        }

        internal double Update()
        {
            if (type == "mousex")
            {
                return Cursor.Position.X;
            }
            else if (type == "mousey")
            {
                return Cursor.Position.Y;
            }

            return 0.0;
        }
    }

    public static class Plugin
    {
        [DllExport]
        public static void Initialize(ref IntPtr data, IntPtr rm)
        {
            data = GCHandle.ToIntPtr(GCHandle.Alloc(new Measure()));
        }

        [DllExport]
        public static void Finalize(IntPtr data)
        {
            GCHandle.FromIntPtr(data).Free();
        }

        [DllExport]
        public static void Reload(IntPtr data, IntPtr rm, ref double maxValue)
        {
            Measure measure = (Measure)GCHandle.FromIntPtr(data).Target;
            measure.Reload(new API(rm), ref maxValue);
        }

        [DllExport]
        public static double Update(IntPtr data)
        {
            Measure measure = (Measure)GCHandle.FromIntPtr(data).Target;
            return measure.Update();
        }
    }
}
