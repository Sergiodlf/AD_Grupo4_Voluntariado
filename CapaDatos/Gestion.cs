using BuscarServidor;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Gestion
    {
        private PROYECTOINTEREntities contexto;
        public Gestion()
        {
            // Constructor que acepta una cadena de conexión personalizada y la pasa a la clase base DbContext
            string servidor = MiServidor.Servidor(out string errores);

            // 1. CAMBIO AQUÍ: Llamamos a esto 'metadata' en vez de 'modelo'
            //Model1 es el nombre del modelo que se ha creado en el EDMX
            string metadata = "res://*/ModeloVoluntariado.csdl|res://*/ModeloVoluntariado.ssdl|res://*/ModeloVoluntariado.msl";

            string baseDatos = "PROYECTOINTER";

            // 2. CAMBIO AQUÍ: Usamos 'metadata' dentro de la cadena
            string cadenaConexion = $@"metadata={metadata};provider=System.Data.SqlClient;provider connection string=""data source={servidor};initial catalog={baseDatos};integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework""";

            // 3. 'this.modelo' se refiere a la variable de la clase (Estado2Entities)
            this.contexto = new PROYECTOINTEREntities(cadenaConexion);
        }
    }
}
