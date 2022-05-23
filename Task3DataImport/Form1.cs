using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3DataImport {
    public partial class Form1 : Form {

        private List<Car> cars = new List<Car>();

        public Form1() {
            InitializeComponent();
        }

        private void importCsv_Click(object sender, EventArgs e) {
            // Skip first line for header
            foreach (string csvLine in File.ReadLines("Technical Test Data.csv").Skip(1)) {
                Car car = Car.FromCsv(csvLine);
                if (!CarExists(car.Registration)) {
                    cars.Add(car);
                }
            }
            resultLabel.Text = $"{cars.Count} results loaded";
        }

        private bool CarExists(string registration) {
            return cars.Any(car => car.Registration == registration);
        }

        private List<Car> GetCarsByValidRegistration() {
            // Regex to match "XY12 ZZZ"
            var myRegex = new Regex(@"^[A-Z]{2}[0-9]{2} [A-Z]{3}$");
            return cars.Where(f => myRegex.IsMatch(f.Registration)).ToList();
        }

        private void ExportByFuelType_Click(object sender, EventArgs e) {

            if (cars.Count == 0) {
                resultLabel.Text = $"No results loaded. Please load file in to memory before exporting";
                return;
            }

            var fuelTypes = new List<string>();
            fuelTypes = cars.Select(x => x.Fuel).Distinct().ToList();

            foreach (string fuelType in fuelTypes) {
                var filteredCars = cars.Where(x => x.Fuel == fuelType);
                var fileName = $"{fuelType}.csv";

                File.WriteAllLines(fileName, filteredCars.Select(x => x.ToCsvLine()));
            }

            resultLabel.Text = $"{fuelTypes.Count} files exported";
        }

        private void getCorrectRegCars_Click(object sender, EventArgs e) {
            var correctRegCars = GetCarsByValidRegistration();
            foreach (var car in correctRegCars) {
                correctRegCarsListBox.Items.Add($"{car.Registration} -- {car.Make} {car.Model}");
            }
            resultLabel.Text = $"{cars.Except(correctRegCars).Count()} cars without a valid registration";


        }
    }
}
