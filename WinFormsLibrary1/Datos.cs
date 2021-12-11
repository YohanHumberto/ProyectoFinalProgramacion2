using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WinFormsLibrary1.Modelos;

namespace WinFormsLibrary1
{
    public class Datos
    {
        public SqlConnection connection;

        public Datos(SqlConnection SQLconnection)
        {
            this.connection = SQLconnection;
        }

        //GetByUserName

        public Entidad GetEntidadesByUserName(string UserName)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Entidades where UserNameEntidad = @UserName", connection);

                command.Parameters.AddWithValue("@UserName", UserName);

                SqlDataReader reader = command.ExecuteReader();

                Entidad data = new Entidad();

                while (reader.Read())
                {
                    data.IdEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Direccion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Localidad = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TipoEntidad = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TipoDocumento = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.NumeroDocumento = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                    data.Teléfonos = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    data.URLPaginaWeb = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    data.URLFacebook = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    data.URLInstagram = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    data.URLTwitter = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    data.URLTikTok = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    data.IdGrupoEntidad = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                    data.IdTipoEntidad = reader.IsDBNull(14) ? 0 : reader.GetInt32(14);
                    data.LimiteCredito = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15);
                    data.UserNameEntidad = reader.IsDBNull(16) ? "" : reader.GetString(16);
                    data.PassworEntidad = reader.IsDBNull(17) ? "" : reader.GetString(17);
                    data.RolUserEntidad = reader.IsDBNull(18) ? "" : reader.GetString(18);
                    data.Comentario = reader.IsDBNull(19) ? "" : reader.GetString(19);
                    data.Status = reader.IsDBNull(20) ? "" : reader.GetString(20);
                    data.NoEliminable = reader.IsDBNull(21) ? new Boolean() : reader.GetBoolean(21);
                }

                reader.Close();
                reader.Dispose();
                connection.Close();

                return data;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

                return null;

            }
        }


        //GETBYID

        public Entidad GetEntidadesById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from Entidades where IdEntidad = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Entidad data = new Entidad();

                while (reader.Read())
                {
                    data.IdEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Direccion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Localidad = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TipoEntidad = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TipoDocumento = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.NumeroDocumento = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                    data.Teléfonos = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    data.URLPaginaWeb = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    data.URLFacebook = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    data.URLInstagram = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    data.URLTwitter = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    data.URLTikTok = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    data.IdGrupoEntidad = reader.IsDBNull(13) ? 0 : reader.GetInt32(13);
                    data.IdTipoEntidad = reader.IsDBNull(14) ? 0 : reader.GetInt32(14);
                    data.LimiteCredito = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15);
                    data.UserNameEntidad = reader.IsDBNull(16) ? "" : reader.GetString(16);
                    data.PassworEntidad = reader.IsDBNull(17) ? "" : reader.GetString(17);
                    data.RolUserEntidad = reader.IsDBNull(18) ? "" : reader.GetString(18);
                    data.Comentario = reader.IsDBNull(19) ? "" : reader.GetString(19);
                    data.Status = reader.IsDBNull(20) ? "" : reader.GetString(20);
                    data.NoEliminable = reader.IsDBNull(21) ? new Boolean() : reader.GetBoolean(21);
                }

                reader.Close();
                reader.Dispose();
                connection.Close();

                return data;


            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

                return null;

            }
        } 

        public GruposEntidad GetGruposEntidadesById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from GruposEntidades where IdGrupoEntidad = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                GruposEntidad data = new GruposEntidad();

                while (reader.Read())
                {
                    data.IdGrupoEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Comentario = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Status = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.NoEliminable = reader.IsDBNull(4) ? new Boolean() : reader.GetBoolean(4);
                }

                reader.Close();
                reader.Dispose();
                connection.Close();

                return data;


            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

                return null;

            }
        } 

        public TiposEntidad GetTiposEntidadesById(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("select * from TiposEntidades where IdTipoEntidad = @id", connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                TiposEntidad data = new TiposEntidad();

                while (reader.Read())
                {
                    data.IdTipoEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.IdGrupoEntidad = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                    data.Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Comentario = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Status = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.NoEliminable = reader.IsDBNull(5) ? new Boolean() : reader.GetBoolean(5);
                }

                reader.Close();
                reader.Dispose();
                connection.Close();

                return data;


            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

                return null;

            }
        }


        //GTLIST

        public List<Entidad> GetListEntidades()
        {
            try
            {
                List<Entidad> list = new List<Entidad>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from Entidades", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Entidad
                    {
                        IdEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Direccion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Localidad = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        TipoEntidad = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        TipoDocumento = reader.IsDBNull(5) ? "" : reader.GetString(5),
                        NumeroDocumento = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6),
                        Teléfonos = reader.IsDBNull(7) ? "" : reader.GetString(7),
                        URLPaginaWeb = reader.IsDBNull(8) ? "" : reader.GetString(8),
                        URLFacebook = reader.IsDBNull(9) ? "" : reader.GetString(9),
                        URLInstagram = reader.IsDBNull(10) ? "" : reader.GetString(10),
                        URLTwitter = reader.IsDBNull(11) ? "" : reader.GetString(11),
                        URLTikTok = reader.IsDBNull(12) ? "" : reader.GetString(12),
                        IdGrupoEntidad = reader.IsDBNull(13) ? 0 : reader.GetInt32(13),
                        IdTipoEntidad = reader.IsDBNull(14) ? 0 : reader.GetInt32(14),
                        LimiteCredito = reader.IsDBNull(15) ? 0 : reader.GetDecimal(15),
                        UserNameEntidad = reader.IsDBNull(16) ? "" : reader.GetString(16),
                        PassworEntidad = reader.IsDBNull(17) ? "" : reader.GetString(17),
                        RolUserEntidad = reader.IsDBNull(18) ? "" : reader.GetString(18),
                        Comentario = reader.IsDBNull(19) ? "" : reader.GetString(19),
                        Status = reader.IsDBNull(20) ? "" : reader.GetString(20),
                        NoEliminable = reader.IsDBNull(21) ? new Boolean() : reader.GetBoolean(21),
                    });
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return list;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public List<GruposEntidad> GetListGruposEntidades()
        {
            try
            {
                List<GruposEntidad> list = new List<GruposEntidad>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from GruposEntidades", connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new GruposEntidad
                    {
                        IdGrupoEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1),
                        Comentario = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Status = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        NoEliminable = reader.IsDBNull(4) ? new Boolean() : reader.GetBoolean(4),
                    });
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return list;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public List<TiposEntidad> GetListTiposEntidades(int IdGrupoEntidad)
        {
            try
            {
                List<TiposEntidad> list = new List<TiposEntidad>();

                connection.Open();

                SqlCommand command = new SqlCommand("Select * from TiposEntidades WHERE IdGrupoEntidad = @IdGrupoEntidad", connection);
                command.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new TiposEntidad
                    {
                        IdTipoEntidad = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        IdGrupoEntidad = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        Descripcion = reader.IsDBNull(2) ? "" : reader.GetString(2),
                        Comentario = reader.IsDBNull(3) ? "" : reader.GetString(3),
                        Status = reader.IsDBNull(4) ? "" : reader.GetString(4),
                        NoEliminable = reader.IsDBNull(5) ? new Boolean() : reader.GetBoolean(5),
                    });
                }

                reader.Close();
                reader.Dispose();

                connection.Close();

                return list;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        //GETALL type DataTable
        public DataTable GetAllEntidades()
        {
            try
            {
                SqlDataAdapter query = new SqlDataAdapter("Select * from Entidades", connection);
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public DataTable GetAllGruposEntidades()
        {
            try
            {
                SqlDataAdapter query = new SqlDataAdapter("Select * from GruposEntidades", connection);
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public DataTable GetAllTiposEntidades()
        {
            try
            {
                SqlDataAdapter query = new SqlDataAdapter("Select * from TiposEntidades", connection);
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        //GETALLByDescription type DataTable 
        //Estos metodos seran utilizados para hacer busquedas en los distintos CRUD

        public DataTable GetAllByDescriptionEntidades(string desccription)
        {
            try
            {
                string sqlquery = "SELECT * FROM Entidades WHERE Descripcion = @desccription OR Descripcion LIKE  @desccription + '%'";
                SqlDataAdapter query = new SqlDataAdapter(sqlquery, connection);
                query.SelectCommand.Parameters.AddWithValue("@desccription", desccription);
                
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public DataTable GetAllByDescriptionGruposEntidades(string desccription)
        {
            try
            {
                string sqlquery = "SELECT * FROM GruposEntidades WHERE Descripcion = @desccription OR Descripcion LIKE  @desccription + '%'";
                SqlDataAdapter query = new SqlDataAdapter(sqlquery, connection);
                query.SelectCommand.Parameters.AddWithValue("@desccription", desccription);
              
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        public DataTable GetAllByDescriptionTiposEntidades(string desccription)
        {
            try
            {
                string sqlquery = "SELECT * FROM TiposEntidades WHERE Descripcion = @desccription OR Descripcion LIKE  @desccription + '%'";
                SqlDataAdapter query = new SqlDataAdapter(sqlquery, connection);
                query.SelectCommand.Parameters.AddWithValue("@desccription", desccription);
                return LoadData(query);
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }
        }

        //ADD
        public bool AddEntidad(Entidad entidad)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Entidades(Descripcion,Direccion, Localidad, TipoEntidad,TipoDocumento,NumeroDocumento,Teléfonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,IdGrupoEntidad,IdTipoEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,Statu,NoEliminable ) values(@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,@NumeroDocumento,@Teléfonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@URLTikTok,@IdGrupoEntidad,@IdTipoEntidad,@LimiteCredito,@UserNameEntidad,@PassworEntidad,@RolUserEntidad,@Comentario,@Status,@NoEliminable)", connection);

            command.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            command.Parameters.AddWithValue("@Direccion", entidad.Direccion);
            command.Parameters.AddWithValue("@Localidad", entidad.Localidad);
            command.Parameters.AddWithValue("@TipoEntidad", entidad.TipoEntidad);
            command.Parameters.AddWithValue("@TipoDocumento", entidad.TipoDocumento);
            command.Parameters.AddWithValue("@NumeroDocumento", entidad.NumeroDocumento);
            command.Parameters.AddWithValue("@Teléfonos", entidad.Teléfonos);
            command.Parameters.AddWithValue("@URLPaginaWeb", entidad.URLPaginaWeb);
            command.Parameters.AddWithValue("@URLFacebook", entidad.URLFacebook);
            command.Parameters.AddWithValue("@URLInstagram", entidad.URLInstagram);
            command.Parameters.AddWithValue("@URLTwitter", entidad.URLTwitter);
            command.Parameters.AddWithValue("@URLTikTok", entidad.URLTikTok);
            command.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);
            command.Parameters.AddWithValue("@IdTipoEntidad", entidad.IdTipoEntidad);
            command.Parameters.AddWithValue("@LimiteCredito", entidad.LimiteCredito);
            command.Parameters.AddWithValue("@UserNameEntidad", entidad.UserNameEntidad);
            command.Parameters.AddWithValue("@PassworEntidad", entidad.PassworEntidad);
            command.Parameters.AddWithValue("@RolUserEntidad", entidad.RolUserEntidad);
            command.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            command.Parameters.AddWithValue("@Status", entidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);

            return ExecuteDML(command);
        }

        public bool AddGruposEntidade(GruposEntidad gruposEntidad)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GruposEntidades(Descripcion,Comentario,Statu,NoEliminable) values(@Descripcion,@Comentario,@Status,@NoEliminable)", connection);

            command.Parameters.AddWithValue("@Descripcion", gruposEntidad.Descripcion);
            command.Parameters.AddWithValue("@Comentario", gruposEntidad.Comentario);
            command.Parameters.AddWithValue("@Status", gruposEntidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", gruposEntidad.NoEliminable);

            return ExecuteDML(command);
        }

        public bool AddTiposEntidade(TiposEntidad tiposEntidad)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TiposEntidades(Descripcion,IdGrupoEntidad,Comentario,Statu,NoEliminable) values(@Descripcion,@IdGrupoEntidad,@Comentario,@Status,@NoEliminable)", connection);

            command.Parameters.AddWithValue("@Descripcion", tiposEntidad.Descripcion);
            command.Parameters.AddWithValue("@IdGrupoEntidad", tiposEntidad.IdGrupoEntidad);
            command.Parameters.AddWithValue("@Comentario", tiposEntidad.Comentario);
            command.Parameters.AddWithValue("@Status", tiposEntidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", tiposEntidad.NoEliminable);

            return ExecuteDML(command);
        }



        //EDIT
        public bool EditEntidad(Entidad entidad)
        {

            SqlCommand command = new SqlCommand("UPDATE Entidades SET Descripcion=@Descripcion,Direccion=@Direccion, Localidad=@Localidad, TipoEntidad=@TipoEntidad,TipoDocumento=@TipoDocumento,NumeroDocumento=@NumeroDocumento,Teléfonos=@Teléfonos,URLPaginaWeb=@URLPaginaWeb,URLFacebook=@URLFacebook,URLInstagram=@URLInstagram,URLTwitter=@URLTwitter,URLTikTok=@URLTikTok,IdGrupoEntidad=@IdGrupoEntidad,IdTipoEntidad=@IdTipoEntidad,LimiteCredito=@LimiteCredito,UserNameEntidad=@UserNameEntidad,PassworEntidad=@PassworEntidad,RolUserEntidad=@RolUserEntidad,Comentario=@Comentario,Statu=@Status,NoEliminable=@NoEliminable WHERE IdEntidad=@IdEntidad ", connection);

            command.Parameters.AddWithValue("@IdEntidad", entidad.IdEntidad);
            command.Parameters.AddWithValue("@Descripcion", entidad.Descripcion);
            command.Parameters.AddWithValue("@Direccion", entidad.Direccion);
            command.Parameters.AddWithValue("@Localidad", entidad.Localidad);
            command.Parameters.AddWithValue("@TipoEntidad", entidad.TipoEntidad);
            command.Parameters.AddWithValue("@TipoDocumento", entidad.TipoDocumento);
            command.Parameters.AddWithValue("@NumeroDocumento", entidad.NumeroDocumento);
            command.Parameters.AddWithValue("@Teléfonos", entidad.Teléfonos);
            command.Parameters.AddWithValue("@URLPaginaWeb", entidad.URLPaginaWeb);
            command.Parameters.AddWithValue("@URLFacebook", entidad.URLFacebook);
            command.Parameters.AddWithValue("@URLInstagram", entidad.URLInstagram);
            command.Parameters.AddWithValue("@URLTwitter", entidad.URLTwitter);
            command.Parameters.AddWithValue("@URLTikTok", entidad.URLTikTok);
            command.Parameters.AddWithValue("@IdGrupoEntidad", entidad.IdGrupoEntidad);
            command.Parameters.AddWithValue("@IdTipoEntidad", entidad.IdTipoEntidad);
            command.Parameters.AddWithValue("@LimiteCredito", entidad.LimiteCredito);
            command.Parameters.AddWithValue("@UserNameEntidad", entidad.UserNameEntidad);
            command.Parameters.AddWithValue("@PassworEntidad", entidad.PassworEntidad);
            command.Parameters.AddWithValue("@RolUserEntidad", entidad.RolUserEntidad);
            command.Parameters.AddWithValue("@Comentario", entidad.Comentario);
            command.Parameters.AddWithValue("@Status", entidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", entidad.NoEliminable);

            return ExecuteDML(command);
        }

        public bool EditGruposEntidade(GruposEntidad gruposEntidad)
        {
            SqlCommand command = new SqlCommand("UPDATE GruposEntidades SET Descripcion=@Descripcion,Comentario=@Comentario,Statu=@Status,NoEliminable=@NoEliminable WHERE IdGrupoEntidad=@IdGrupoEntidad", connection);

            command.Parameters.AddWithValue("@IdGrupoEntidad", gruposEntidad.IdGrupoEntidad);
            command.Parameters.AddWithValue("@Descripcion", gruposEntidad.Descripcion);
            command.Parameters.AddWithValue("@Comentario", gruposEntidad.Comentario);
            command.Parameters.AddWithValue("@Status", gruposEntidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", gruposEntidad.NoEliminable);

            return ExecuteDML(command);
        }

        public bool EditTiposEntidade(TiposEntidad tiposEntidad)
        {
            SqlCommand command = new SqlCommand("UPDATE TiposEntidades SET Descripcion=@Descripcion,IdGrupoEntidad=@IdGrupoEntidad,Comentario=@Comentario,Statu=@Status,NoEliminable=@NoEliminable WHERE IdTipoEntidad=@IdTipoEntidad", connection);

            command.Parameters.AddWithValue("@IdTipoEntidad", tiposEntidad.IdTipoEntidad);
            command.Parameters.AddWithValue("@Descripcion", tiposEntidad.Descripcion);
            command.Parameters.AddWithValue("@IdGrupoEntidad", tiposEntidad.IdGrupoEntidad);
            command.Parameters.AddWithValue("@Comentario", tiposEntidad.Comentario);
            command.Parameters.AddWithValue("@Status", tiposEntidad.Status);
            command.Parameters.AddWithValue("@NoEliminable", tiposEntidad.NoEliminable);

            return ExecuteDML(command);
        }



        //DELETE
        public bool DeleteEntidad(int IdEntidad)
        {
            SqlCommand command = new SqlCommand("DELETE Entidades WHERE IdEntidad = @IdEntidad", connection);

            command.Parameters.AddWithValue("@IdEntidad", IdEntidad);

            return ExecuteDML(command);
        }

        public bool DeleteGruposEntidade(int IdGrupoEntidad)
        {
            SqlCommand command = new SqlCommand("DELETE GruposEntidades WHERE IdGrupoEntidad = @IdGrupoEntidad", connection);

            command.Parameters.AddWithValue("@IdGrupoEntidad", IdGrupoEntidad);

            return ExecuteDML(command);
        }

        public bool DeleteTiposEntidade(int IdTipoEntidad)
        {
            SqlCommand command = new SqlCommand("DELETE TiposEntidades WHERE IdTipoEntidad = @IdTipoEntidad", connection);

            command.Parameters.AddWithValue("@IdTipoEntidad", IdTipoEntidad);

            return ExecuteDML(command);
        }



        //GENERICOS
        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();
                connection.Open();
                query.Fill(data);
                connection.Close();
                return data;
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return null;
            }

        }

        public bool ExecuteDML(SqlCommand query)
        {
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                connection.Close();
                return true;
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                return false;
            }
        }
    }
}
