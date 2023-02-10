using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*class cutomer
    {
        public int custid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        public int pnumber { get; set; }
    }

    class cutomeroperations
    {
        List<cutomer> customers;

        public cutomeroperations()
        {
            customers = new List<cutomer>();
        }

        public void adddcustomer(cutomer c)
        {
            customers.Add(c);
        }

        public List<cutomer> getcustomer()
        {
            return customers;
        }

        public void RemoveCustomer(int x)
        {
            customers.RemoveAt(x - 1);
        }
    }
    internal class ex61
    {
        public static void Main()
        {
            cutomeroperations cutomeroperations = new cutomeroperations();
            cutomeroperations.adddcustomer(new cutomer()
            {
                custid = 1,
                fname = "ram",
                lname = "patil",
                pnumber = 12

            });

            cutomeroperations.adddcustomer(new cutomer()
            {
                custid = 2,
                fname = "shyam",
                lname = "parker",
                pnumber = 23

            });

            //cutomeroperations.removecustomer();

           // cutomeroperations.removecustomer(new cutomer()

            foreach (var cutomer in cutomeroperations.getcustomer())
            {
                Console.WriteLine(cutomer.custid);
                Console.WriteLine(cutomer.fname);
                Console.WriteLine(cutomer.lname);
                Console.WriteLine(cutomer.pnumber);
            }


            cutomeroperations.RemoveCustomer(2);
            Console.WriteLine("--------------------------After Removal ----------------------");
            foreach (var i in cutomeroperations.getcustomer())
            {
                Console.WriteLine(i.custid);
                Console.WriteLine(i.fname);
                Console.WriteLine(i.lname);
                Console.WriteLine(i.pnumber);
            }


        }
    }*/
}
