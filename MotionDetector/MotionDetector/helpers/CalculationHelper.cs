using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionDetector.model;

namespace MotionDetector.helpers
{
    static public class CalculationHelper
    {
        public static double GetSad(IBloc referenceBloc, IBloc bloc)
        {
            return referenceBloc.SAD(bloc);
        }

        public static IEnumerable<int> BuildBlocListFromImage(int width,int height,int blocSize)
        {

            return null;
        }

        public static void ZMP(int threshold,  List<IBloc> reference,  List<IBloc> current)
        {
            Func<IBloc,IBloc,bool> action =delegate(IBloc refe,IBloc curr) {
                return refe.SAD(curr) > threshold;
                       };
            reference.Select(
                (a,i)=> action(a,current[i])
                );
        }
    }
}
