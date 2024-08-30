using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services {
    internal class CalculationService {

        public generic Max<generic>(List<generic> list) where generic : IComparable {
            if (list.Count == 0) {
                throw new ArgumentException("The list can not be empty");
            }                      

            generic max = list[0];
            for (int i = 1; i < list.Count; i++) {
                if (list[i].CompareTo(max) > 0) {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
