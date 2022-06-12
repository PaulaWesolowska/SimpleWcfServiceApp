using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    public class Service1 : IService1
    {
        People people = new People();
        //public List<People> GetPersonData(String lastName)
        public string GetPersonData(String lastName)
        {
            return people.GetData(lastName).ToString();//.ToString();
        }

        public string Gd(string l)
        {
            return l;
        }
    }

}
