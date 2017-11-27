using SOAP_SERVICE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAP_SERVICE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        string GetData(int value);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        string GetToken(string userName, string password);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        List<LecturasModel> GetLecturas();

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        LecturasModel GetLectura(int id);

        [OperationContract]
        [FaultContract(typeof(ExceptionMessage))]
        String AddLecturas(LecturasModel lectura);

        // TODO: agregue aquí sus operaciones de servicio
    }

    [DataContract]
    public class ExceptionMessage
    {
        private string infoExceptionMessage;
        public ExceptionMessage(string Message)
        {
            this.infoExceptionMessage = Message;
        }
        [DataMember]
        public string errorMessageOfAction
        {
            get { return this.infoExceptionMessage; }
            set { this.infoExceptionMessage = value; }
        }
    }



}
