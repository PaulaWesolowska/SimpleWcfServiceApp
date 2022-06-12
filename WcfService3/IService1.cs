using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //List<People> GetPersonData(string lastName);
        string GetPersonData(string lastName);
        string Gd(string l);
    }

}
