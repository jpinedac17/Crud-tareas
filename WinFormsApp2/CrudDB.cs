using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
// dotnet add package Microsoft.Data.SqlClient

namespace WinFormsApp2
{
    internal class CrudDB
    {
        string connectionString = "Server=DESKTOP-DVB2F0D\\SQLEXPRESS;Database=UMG;Integrated Security=True; TrustServerCertificate=True; ";

        public void MostrarInformacion()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Tb_alumnos";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Carnet: {reader["carnet"]}, Nombre: {reader["Estudiante"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
        }

        public void AgregarAlumno(string carnet, string nombre, string email, string seccion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into Tb_Alumnos (carnet, Estudiante, email, seccion) values (@carnet, @Estudiante, @email, @seccion)";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@Estudiante", nombre);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Alumno agregado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void ActualizarAlumno(string carnet, string Estudiante, string email, string seccion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Update Tb_alumnos set Estudiante = @Estudiante, email = @email, seccion = @seccion where carnet = @carnet";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@Estudiante", Estudiante);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@seccion", seccion);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno actualizado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void EliminarALumno(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Delete from Tb_alumnos where carnet = @carnet";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno eliminado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        //Crud de la tabla tareas
        public void MostrarTareas(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from tareas where carnet = @carnet";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Carnet: {reader["carnet"]}, Nota 1: {reader["nota1"]}, Nota 2: {reader["nota2"]}, Nota 3: {reader["nota3"]}, Nota 4: {reader["nota4"]}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
                connection.Close();
            }
        }

        public void AgregarTareas(string carnet, string nota1, string nota2, string nota3, string nota4)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Insert into tareas (carnet, nota1, nota2, nota3, nota4) values (@carnet, @nota1, @nota2, @nota3, @nota4)";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Registro de notas agregado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void ActualizarTareas(string carnet, int nota1, int nota2, int nota3, int nota4)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Update tareas set nota1 = @nota1, nota2 = @nota2, nota3 = @nota3, nota4 = @nota4 where carnet = @carnet";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    command.Parameters.AddWithValue("@nota1", nota1);
                    command.Parameters.AddWithValue("@nota2", nota2);
                    command.Parameters.AddWithValue("@nota3", nota3);
                    command.Parameters.AddWithValue("@nota4", nota4);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Registro de notas actualizado" : "No se encontró el registro de notas");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void EliminarTareas(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Delete from tareas where carnet = @carnet";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Registro de notas eliminado" : "No se encontró el registro de notas");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        // Clases para el formulario
        public string? ObtenerNombrePorCarnet(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Estudiante FROM Tb_alumnos WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader["Estudiante"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }

        public string? ObtenerSeccion(string carnet)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT seccion FROM Tb_alumnos WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader["seccion"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }

        public string? ObtenerNota(string carnet, string nota)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT {nota} FROM tareas WHERE carnet = @carnet";
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@carnet", carnet);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader[$"{nota}"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }
    }
}
