using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionDetector.model;


namespace MotionDetector.model
{
    public abstract class IBloc
    {
        public int X;
        public int Y;
        public int Window;
        public int BlocSize;
        public int Width;
        public int Height;
        public UnsafeBitmap ReferenceFrame;
        public UnsafeBitmap CurrentFrame;

        public double SAD(IBloc current)
        {
            double sad = 0;
            PixelData pixelReferenceData;
            PixelData pixelCandidateData;
            int x1, x2, y1, y2;
            // PixelData t3 = new PixelData();
            //accés au pixel
            double val1, val2;

            for (int i = 0; i < BlocSize; i++)
            {
                for (int j = 0; j < BlocSize; j++)
                {
                    x1 = Math.Max(0, Math.Min(Width - 1, (X + i)));
                    y1 = Math.Max(0, Math.Min(Height - 1, (Y + j)));
                    x2 = Math.Max(0, Math.Min(Width - 1, (current.X + i)));
                    y2 = Math.Max(0, Math.Min(Height - 1, (current.Y + j)));
                    pixelReferenceData = ReferenceFrame.GetPixel(x1, y1);
                    pixelCandidateData = CurrentFrame.GetPixel(x2, y2);
                    val1 = pixelReferenceData.blue * 0.1140 + pixelReferenceData.green * 0.5870 + pixelReferenceData.red * 0.2989;
                    val2 = pixelCandidateData.blue * 0.1140 + pixelCandidateData.green * 0.5870 + pixelCandidateData.red * 0.2989;
                    sad += Math.Abs(val1 - val2);
                }
            }
            return sad;
        }

        public bool InTheWindow(IBloc current)
        {
            int deplace_fen = Window / 2;
            return
                (current.X >= X - deplace_fen) && (current.X <= X + deplace_fen)
            &&  (current.Y >= Y - deplace_fen) && (current.Y <= Y + deplace_fen)
            &&  (current.X + BlocSize < Width && current.Y + BlocSize < Height)
            &&  (current.X >= 0 && current.Y >= 0);

        }

    }
}
