using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PedidosProductosRodando
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        EXAMPLEEntities1 db = new EXAMPLEEntities1();
        Employees detail;

        public List<Employees> DisplayEmployees()
        {

            var test = db.Employees.ToList();

            return test;
        }

        public Employees SearchEmployees(int id)
        {
            try
            {
                int iden = Convert.ToInt32(id);

                detail = db.Employees.Find(iden);
                return detail;

            } catch (Exception ex)
            {

            }
            return detail;
        }
    }
}
