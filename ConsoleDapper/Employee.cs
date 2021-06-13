using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDapper
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }


        public void PrintEmployee()
        {
            string info = String.Format("Çalışan Id: {0}.\nÇalışanın Adı : {1}.\nÇalışanın Adresi: {2}.\nÇalışanın Cep Telefonu: {3}. ", Id, Name, Address, CellPhone);
            Console.WriteLine(info);
        }

    }

}