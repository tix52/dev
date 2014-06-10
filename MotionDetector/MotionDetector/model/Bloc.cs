using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionDetector.model
{
    public class Bloc
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Bloc tmp = obj as Bloc;
            return (tmp.X==this.X) && (tmp.Y==this.Y);
        }

        public override string ToString()
        {
            return string.Format("X= {0}, Y= {1}",X ,Y);
        }

    }
}
