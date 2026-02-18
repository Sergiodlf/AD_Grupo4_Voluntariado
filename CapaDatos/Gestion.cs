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

            // 3. 'this.contexto' se refiere a la variable de la clase (Estado2Entities)
            this.contexto = new PROYECTOINTEREntities(cadenaConexion);
        }

        public List<VOLUNTARIO> Voluntarios()
        {
            return contexto.VOLUNTARIOS.ToList();
        }

        public List<ORGANIZACIONE> Organizaciones()
        {
            return contexto.ORGANIZACIONES.ToList();
        }

        public List<ACTIVIDADE> Actividades()
        {
            return contexto.ACTIVIDADES.ToList();
        }

        public List<OD> Ods()
        {
            return contexto.ODS.OrderBy(ods => ods.id).ToList();
        }

        public List<CICLO>Ciclos()
        {
            return contexto.CICLOS.OrderBy(ciclo => ciclo.NOMBRE).ToList();
        }

        public List<INSCRIPCIONE> Matches()
        {
            return contexto.INSCRIPCIONES.ToList();
        }

        public List<string> NombreOdsPorId(List<int> idsOds)
        {
            return contexto.ODS.Where(o => idsOds.Contains(o.id)).Select(o => o.nombre).ToList();
        }

        public List<ACTIVIDADE> ActividadesPorOds(List<int> idsOds)
        {

            return contexto.ACTIVIDADES
                .Where(a => a.ODS.Any(o => idsOds.Contains(o.id)))
                .ToList();
        }

        public List<VOLUNTARIO> VoluntariosPorOds(List<int> idsOds)
        {
            return contexto.VOLUNTARIOS
                .Where(v => v.INSCRIPCIONES
                    .Any(i => i.ACTIVIDADE.ODS
                        .Any(o => idsOds.Contains(o.id))))
                .Distinct()
                .ToList();
        }

        public List<ORGANIZACIONE> OrganizacionesPorOds(List<int> idsOds)
        {
            return contexto.ORGANIZACIONES
                .Where(o => o.ACTIVIDADES
                    .Any(a => a.ODS
                        .Any(ods => idsOds.Contains(ods.id))))
                .Distinct()
                .ToList();
        }

        public List<VOLUNTARIO> VoluntariosPorTrozoDeNombre(string trozoNombre)
        {
            return contexto.VOLUNTARIOS.Where(v => v.NOMBRE.StartsWith(trozoNombre)).ToList();
        }

        public List<ORGANIZACIONE> OrganizacionesPorTrozoDeNombre(string trozoNombre)
        {
            return contexto.ORGANIZACIONES.Where(o => o.NOMBRE.StartsWith(trozoNombre)).ToList();
        }

        public List<ACTIVIDADE> ActividadesPorRango(DateTime inicio, DateTime fin)
        {
            return contexto.ACTIVIDADES
             .Where(a => a.FECHA_INICIO >= inicio && a.FECHA_FIN <= fin)
             .ToList();
        }

        public bool ExisteInscripcion(string dni, short codActividad)
        {
            return contexto.INSCRIPCIONES.Any(i => i.DNI_VOLUNTARIO == dni && i.CODACTIVIDAD == codActividad);
        }

        public int ContarInscritos(short codActividad, out string mensaje)
        {
            mensaje = "";
            try { return contexto.INSCRIPCIONES.Count(i => i.CODACTIVIDAD == codActividad); }
            catch (Exception ex) { mensaje = ex.Message; return -1; }
        }
        public bool CrearMatch(string dniVoluntario, short codActividad, out string mensaje)
        {
            try
            {
                var nuevaInscripcion = new INSCRIPCIONE(dniVoluntario.ToUpper(), codActividad);

                contexto.INSCRIPCIONES.Add(nuevaInscripcion);

                contexto.SaveChanges();

                mensaje = "Inscripción realizada con éxito.";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = "No se pudo realizar la inscripción: " + ex.Message;
                return false;
            }
        }

        public bool CrearVoluntario(string dni, string nombre, string apellido1, string apellido2, string correo, string zona, DateTime fechaNac, string experiencia, bool coche, short? curso, string nombreCiclo)
        {
            VOLUNTARIO vol = new VOLUNTARIO(dni.ToUpper(), nombre, apellido1, apellido2, correo, zona, fechaNac, experiencia, coche, curso, nombreCiclo);
            int nAfectados = 0;
            contexto.VOLUNTARIOS.Add(vol);
            try { 
                nAfectados = contexto.SaveChanges();
                if (nAfectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception) { return false; }
        }

        public bool CrearOrganizacion(string cif, string nombre, string email, string sector, string direccion, string localidad, string cp, string descripcion, string telefono)
        {
            ORGANIZACIONE org = new ORGANIZACIONE(cif.ToUpper(), nombre, email, sector, direccion, localidad, cp, descripcion, telefono);

            int nAfectados = 0;
            contexto.ORGANIZACIONES.Add(org);
            try
            {
                nAfectados = contexto.SaveChanges();
                if (nAfectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception) { return false; }
        }

        public bool CrearActividad(string nombre, string direccion, DateTime fechaInicio, DateTime fechaFin, short MaxParticipantes, string cif, string sector, string descripcion)
        {
            ACTIVIDADE act = new ACTIVIDADE(nombre, direccion, fechaInicio, fechaFin, MaxParticipantes, cif, sector, descripcion);

            int nAfectados = 0;
            contexto.ACTIVIDADES.Add(act);
            try
            {
                nAfectados = contexto.SaveChanges();
                if (nAfectados > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception) { return false; }
        }
    }
}
