using System;
using System.Collections.Generic;
using System.Text;

namespace Task3DataImport {
    internal class Car {
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Fuel { get; set; }

        public string ToCsvLine() {
            return $"{Registration}, {Make}, {Model}, {Colour}, {Fuel}";
        }

        public static Car FromCsv(string csvLine) {
            string[] lineValues = csvLine.Split(',');

            Car car = new Car {
                Registration = lineValues[0],
                Make = lineValues[1],
                Model = lineValues[2],
                Colour = lineValues[3],
                Fuel = lineValues[4]
            };

            return car;
        }

    }
}
