
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PedidosProductosRodando
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //[OperationContract]
        //bool AgregarPedido (Pedidos Pedido);

        //[OperationContract]
        //bool BorrarPedido (Pedidos Pedido);

        //[OperationContract]
        //bool EditarPedido(Pedidos Pedido);

        [OperationContract]
        List<Employees> DisplayEmployees();

        

        [OperationContract]
        Employees SearchEmployees(int id);
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "PedidosProductosRodando.ContractType".
    
}
