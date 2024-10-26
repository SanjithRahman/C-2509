using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class MobilePhone
    {
        public string Brand;
        public string Modal;
        public MobilePhone(string brand,string model) {
            
            Brand = brand;
            Modal = model;
        }
        public MobilePhone(MobilePhone phone) {
            Brand= phone.Brand;
            Modal = phone.Modal;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Phone Brand    {Brand}   and its modal is  {Modal}   ");

        }


    }
}
