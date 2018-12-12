/* Developer: Byron Buyck （毕容谦）
 * Date: 12/11/2018
 * Application: AddressBook
 * Description: Simple Form Application that takes input from user and saves it to the user's 
 * OS as a text file. If txt file is opened in the application, the contents of the file are
 * displayed in textbox.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Addresses
    {
        private string name { get; set; }
        private string address { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zipCode { get; set; }
        private string phoneNum { get; set; }

        public Addresses()
        {
        }

        public Addresses(string fName, string ad, string cty, string st, string zip, string pNum)
        {
            name = fName;
            address = ad;
            city = cty;
            state = st;
            zipCode = zip;
            phoneNum = pNum;
        }
        public override string ToString()
        {
            return "Name: " + name +
                "\r\nAddress: " + address +
                "\r\nCity: " + city +
                " State: " + state +
                " Zip Code: " + zipCode +
                "\r\nPhone#: " + phoneNum;
                ;
        }

    }
    




}
