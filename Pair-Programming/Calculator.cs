using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming {
   public class Calculator {

        public int Sum(string number="0") {
            if (number.Contains(",")) {
                string[] values = number.Split(",");
                //string[] newLine = new string[values.Length];
                //string[] result_values = values.ToList()

                // for (int i = 0; i < values.Length; i++) {
                //     //if (values[i]) {

                //     //}
                //     values[i].Split("\n");
                // }
                int result = 0;
                for (int i = 0; i < values.Length; i++) {
                    result += Int32.Parse(values[i]);
                }
                return result;
            }
            return Int32.Parse(number);
        }
    }
}
