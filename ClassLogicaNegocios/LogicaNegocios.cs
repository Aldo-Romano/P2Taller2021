using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassAccesoDatos;
using ClassEntidades;
using System.Data;
using System.Data.SqlClient;

namespace ClassLogicaNegocios
{
    public class LogicaNegocios
    {
        //Cadena de Conexión.
        private AccesoDatos obAcc = new AccesoDatos(@"Data Source=ISMARI; Initial Catalog=MiTaller2021; Integrated Security = true;");

        //Insertar Clientes.
        public Boolean InsertarClientes(Clientes nuevoCliente, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[7];
            param1[0] = new SqlParameter
            {
                ParameterName = "idClien",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.id_cliente

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "nom",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.nombre

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "app",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.app

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "apm",
                SqlDbType = SqlDbType.VarChar,
                Size = 90,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.apm

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "cel",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.celular

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "telO",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.telOficina

            };
            param1[6] = new SqlParameter
            {
                ParameterName = "correoP",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.correoPer

            };
            param1[7] = new SqlParameter
            {
                ParameterName = "correoC",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevoCliente.correoCorp

            };
            string sentenciaSql = "insert into Cliente values(@idClien,@nom,@app,@apm,@cel,@telO,@correoP,@correoC);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Insertar Autos.
        public Boolean InsertarAutos(Autos nuevoAuto, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[6];
            param1[0] = new SqlParameter
            {
                ParameterName = "idAut",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.id_Auto

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "marc",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.f_marca

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "model",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.modelo

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "anio",
                SqlDbType = SqlDbType.VarChar,
                Size = 4,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.año

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "color",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.color

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "plac",
                SqlDbType = SqlDbType.VarChar,
                Size = 16,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.placas

            };
            param1[6] = new SqlParameter
            {
                ParameterName = "duen",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevoAuto.dueño

            };

            string sentenciaSql = "insert into Auto values(@idAut,@marc,@model,@anio,@color,@plac,@duen);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Mostrar/Devolver Clientes.
        public List<Clientes> DevuelveClientesID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Cliente";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Clientes> listaSalida = new List<Clientes>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Clientes
                    {
                        id_cliente = (int)datos[0],
                        nombre = (string)datos[1],
                        app = (string)datos[2],
                        apm = (string)datos[3],
                        celular = (string)datos[4],
                        telOficina = (string)datos[5],
                        correoPer = (string)datos[6],
                        correoCorp = (string)datos[7]

                    }
                     );
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;

        }
        //Mostrar/Devolver Autos.
        public List<Autos> DevuelveAutosID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Auto";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Autos> listaSalida = new List<Autos>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Autos
                    {
                        id_Auto = (int)datos[0],
                        f_marca = (int)datos[1],
                        modelo = (string)datos[2],
                        año = (string)datos[3],
                        color = (string)datos[4],
                        placas = (string)datos[5],
                        dueño = (int)datos[6]

                    }
                     );
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;

        }

        //Insertar Marca.
        public Boolean InsertarMarca(Marcas nuevaMarca, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[1];
            param1[0] = new SqlParameter
            {
                ParameterName = "idMarca",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaMarca.id_marca
            };
            param1[1] = new SqlParameter
            {
                ParameterName = "marca",
                SqlDbType = SqlDbType.VarChar,
                Size = 120,
                Direction = ParameterDirection.Input,
                Value = nuevaMarca.marca

            };
            string sentenciaSql = "insert into Marcas values(@idMarca,@marca);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Insertar Reparaciones.
        public Boolean InsertarReparaciones(Reparaciones nuevaReparacion, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[4];
           
            param1[0] = new SqlParameter
            {
                ParameterName = "detalles",
                SqlDbType = SqlDbType.NVarChar,
                Size = 300,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.detalles

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "garantia",
                SqlDbType = SqlDbType.VarChar,
                Size = 40,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.garantia

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "salida",
                SqlDbType = SqlDbType.Date,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.salida

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "fk_revision",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaReparacion.Fk_revision

            };
            string sentenciaSql = "insert into Reparacion values(@detalles,@garantia,@salida,@fk_revision);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }

        //Mostrar y devolver Marcas.
        public List<Marcas> DevuelveMarcasID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Marcas";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Marcas> listaSalida = new List<Marcas>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Marcas
                    {
                        id_marca = (int)datos[0],
                        marca = (string)datos[1],
                    });
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;
        }
        // Mostrar y devolver Reparaciones.
        public List<Reparaciones> DevuelveReparacionID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Reparacion";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Reparaciones> listaSalida = new List<Reparaciones>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Reparaciones
                    {
                        id_reparacion = (int)datos[0],
                        detalles = (string)datos[1],
                        garantia = (string)datos[2],
                        salida = (DateTime)datos[3],
                        Fk_revision = (int)datos[4],
                    }
                     );
                }
            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;
        }

        //Insertar Revisiones.
        public Boolean InsertarRevisiones(Revisiones nuevaRev, ref string msjSalida)
        {
            SqlParameter[] param1 = new SqlParameter[6];
            
            param1[0] = new SqlParameter
            {
                ParameterName = "Entrada",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Entrada

            };
            param1[1] = new SqlParameter
            {
                ParameterName = "Falla",
                SqlDbType = SqlDbType.VarChar,
                Size = 300,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Falla

            };
            param1[2] = new SqlParameter
            {
                ParameterName = "Dignostico",
                SqlDbType = SqlDbType.VarChar,
                Size = 350,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.diagnostico

            };
            param1[3] = new SqlParameter
            {
                ParameterName = "Autorizacion",
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Autorizacion

            };
            param1[4] = new SqlParameter
            {
                ParameterName = "Auto",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Auto

            };
            param1[5] = new SqlParameter
            {
                ParameterName = "Mecanico",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = nuevaRev.Mecanico

            };

            string sentenciaSql = "insert into Revision values(@Entrada,@Falla,@Dignostico,@Autorizacion,@Auto,@Mecanico);";

            Boolean salida = false;
            salida = obAcc.ModificaBDMasSegura(sentenciaSql, obAcc.AbrirConexion(ref msjSalida), ref msjSalida, param1);

            return salida;
        }
      

        //Mostrar/Devolver Revisiones.
        public List<Revisiones> DevuelveRevisionID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Revision";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Revisiones> listaSalida = new List<Revisiones>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Revisiones
                    {
                        id_Revision = (int)datos[0],
                        diagnostico = (string)datos[3],
                        

                    }
                );
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;

        }

        public List<Mecanicos> DevuelveMecanicoID(ref string msj)
        {
            SqlConnection conextemp = null;
            string query = "select * from Mecanico";

            conextemp = obAcc.AbrirConexion(ref msj);

            SqlDataReader datos = null;
            datos = obAcc.ConsultaReader(query, conextemp, ref msj);

            List<Mecanicos> listaSalida = new List<Mecanicos>();
            if (datos != null)
            {
                while (datos.Read())
                {
                    listaSalida.Add(new Mecanicos
                    {
                        id_Tecnico = (int)datos[0],
                        Nombre = (string)datos[1],
                        App = (string)datos[2],
                        Apm = (string)datos[3],
                        Celular = (string)datos[4],
                        Correo = (string)datos[5]

                    }
                     );
                }

            }
            else
            {
                listaSalida = null;
            }
            conextemp.Close();
            conextemp.Dispose();

            return listaSalida;

        }

        public DataTable GridHistAuto(string placas, ref string mens_salida)
        {
            string query2 = "select Nombre,App,Apm,Entrada,Falla,diagnostico,Modelo,año,placas,Detalles,Garantia,Salida from Revision r inner join Mecanico m on r.Mecanico = m.id_Tecnico inner join Auto a on r.Auto=a.Id_Auto inner join Reparacion rp on r.id_Revision=rp.Fk_Revision where placas ='" + placas + "'";


            DataSet cont_atrapa = null;
            DataTable tablaS = null;

            cont_atrapa = obAcc.ConsultaDS(query2, obAcc.AbrirConexion(ref mens_salida), ref mens_salida);

            if (cont_atrapa != null)
            {
                tablaS = cont_atrapa.Tables[0];
            }
            return tablaS;
        }

    }
}
