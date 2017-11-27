using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SOAP_SERVICE.Models
{
    [DataContract]
    public class LecturasModel
    {   
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int LecturaUno { get; set; }
        [DataMember]
        public int LecturaDos { get; set; }
        [DataMember]
        public int LecturaTres { get; set; }
    }
}