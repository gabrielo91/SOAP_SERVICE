﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SOAP_SERVICE.Models;

namespace SOAP_SERVICE
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string AddLecturas(LecturasModel lectura)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public LecturasModel GetLectura(int id)
        {
            throw new NotImplementedException();
        }

        public List<LecturasModel> GetLecturas()
        {
            throw new NotImplementedException();
        }

        public string GetToken(string userName, string password)
        {
            if (userName == "testUser" && password == "testPassword")
            {
                return Guid.NewGuid().ToString();
            }
            else
            {
                return "you failed";
            }
        }
    }
}
