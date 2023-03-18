using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sells_system
{
    public class Manufacturer
    {
        private string manufacturerName;
        private string manufacturerLegel;
        private string manufacturerPhone;
        private string manufacturerAdress;

        public string ManufacturerName { get => manufacturerName; set => manufacturerName = value; }
        public string ManufacturerLegel { get => manufacturerLegel; set => manufacturerLegel = value; }
        public string ManufacturerPhone { get => manufacturerPhone; set => manufacturerPhone = value; }
        public string ManufacturerAdress { get => manufacturerAdress; set => manufacturerAdress = value; }
    }
}
