using Microsoft.Extensions.Configuration;
using PracticoSI1.Business.Contracts;
using PracticoSI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace PracticoSI1.Business.Clases
{
    public class clInsumoRepository : IclInsumoRepository
    {
        private readonly string conect;

        public clInsumoRepository(IConfiguration _con)
        {
            conect = _con.GetConnectionString("conBase");
        }

        public async Task<List<clInsumo>> GetList()
        {
            List<clInsumo> list = new List<clInsumo>();
            clInsumo l;

            using (SqlConnection con = new SqlConnection(conect))
            {
                await con.OpenAsync();
                SqlCommand cmd = new SqlCommand("SELECT IdInsumo, Codigo1, Codigo2, NombreInsumo, Imagen, CantidadMaxima, CantidadMinima, PrecioCompra, ConFechaVencimiento, IdMoneda, IdLineaArticulo, IdGrupoArticulo, IdUnidadMedida, IdSerializacion, IdMarca, IdColor, Estante, Nivel, FechaRegistro, EstadoRegistro FROM clInsumo;", con);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        l = new clInsumo();
                        l.IdInsumo = Convert.ToInt32(reader["IdInsumo"]);
                        l.Codigo1 = Convert.ToInt32(reader["Codigo1"]);
                        l.Codigo2 = Convert.ToInt32(reader["Codigo2"]);
                        l.NombreInsumo = Convert.ToString(reader["NombreInsumo"]);
                        l.Imagen = Convert.ToString(reader["Imagen"]);
                        l.CantidadMaxima = Convert.ToInt32(reader["CantidadMaxima"]);
                        l.CantidadMinima = Convert.ToInt32(reader["CantidadMinima"]);
                        l.PrecioCompra = Convert.ToDecimal(reader["PrecioCompra"]);
                        l.ConFechaVencimiento = Convert.ToDateTime(reader["ConFechaVencimiento"]);
                        l.IdMoneda = Convert.ToInt32(reader["IdMoneda"]);
                        l.IdLineaArticulo = Convert.ToInt32(reader["IdLineaArticulo"]);
                        l.IdGrupoArticulo = Convert.ToInt32(reader["IdGrupoArticulo"]);
                        l.IdUnidadMedida = Convert.ToInt32(reader["IdUnidadMedida"]);
                        l.IdSerialización = Convert.ToInt32(reader["IdSerialización"]);
                        l.IdMarca = Convert.ToInt32(reader["IdMarca"]);
                        l.IdColor = Convert.ToInt32(reader["IdColor"]);
                        l.Estante = Convert.ToString(reader["Estante"]);
                        l.Nivel = Convert.ToString(reader["Nivel"]);
                        l.FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
                        l.EstadoRegistro = Convert.ToString(reader["EstadoRegistro"]);

                        list.Add(l);
                    }
                }
                return list;
            }
        }

        public async Task<int> Elimina(clInsumo l)
        {
            using (SqlConnection con = new SqlConnection(conect))
            {
                string cadena = "DELETE FROM clInsumo WHERE IdInsumo = @IdInsumo;";

                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@IdInsumo", l.IdInsumo);

                    await con.OpenAsync();

                    // Ejecutamos la consulta de eliminación
                    return await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<clInsumo> AgregaActualiza(clInsumo l, string t)
        {
            using (SqlConnection con = new SqlConnection(conect))
            {
                string cadena = "";
                if (t == "c")
                {
                    cadena = "INSERT INTO clInsumo (Codigo1, Codigo2, NombreInsumo, Imagen, CantidadMaxima, CantidadMinima, PrecioCompra, ConFechaVencimiento, IdMoneda, IdLineaArticulo, IdGrupoArticulo, IdUnidadMedida, IdSerialización, IdMarca, IdColor, Estante, Nivel, FechaRegistro, EstadoRegistro) " +
                             "VALUES (@Codigo1, @Codigo2, @NombreInsumo, @Imagen, @CantidadMaxima, @CantidadMinima, @PrecioCompra, @ConFechaVencimiento, @IdMoneda, @IdLineaArticulo, @IdGrupoArticulo, @IdUnidadMedida, @IdSerialización, @IdMarca, @IdColor, @Estante, @Nivel, @FechaRegistro, @EstadoRegistro); SELECT SCOPE_IDENTITY();";
                }
                else if (t == "u")
                {
                    cadena = "UPDATE clInsumo SET Codigo1 = @Codigo1, Codigo2 = @Codigo2, NombreInsumo = @NombreInsumo, Imagen = @Imagen, CantidadMaxima = @CantidadMaxima, CantidadMinima = @CantidadMinima, PrecioCompra = @PrecioCompra, ConFechaVencimiento = @ConFechaVencimiento, IdMoneda = @IdMoneda, IdLineaArticulo = @IdLineaArticulo, IdGrupoArticulo = @IdGrupoArticulo, IdUnidadMedida = @IdUnidadMedida, IdSerializacion = @IdSerialización, IdMarca = @IdMarca, IdColor = @IdColor, Estante = @Estante, Nivel = @Nivel, FechaRegistro = @FechaRegistro, EstadoRegistro = @EstadoRegistro WHERE IdInsumo = @IdInsumo;";
                }

                using (SqlCommand cmd = new SqlCommand(cadena, con))
                {
                    cmd.Parameters.AddWithValue("@IdInsumo", l.IdInsumo);
                    cmd.Parameters.AddWithValue("@Codigo1", l.Codigo1);
                    cmd.Parameters.AddWithValue("@Codigo2", l.Codigo2);
                    cmd.Parameters.AddWithValue("@NombreInsumo", l.NombreInsumo);
                    cmd.Parameters.AddWithValue("@Imagen", l.Imagen);
                    cmd.Parameters.AddWithValue("@CantidadMaxima", l.CantidadMaxima);
                    cmd.Parameters.AddWithValue("@CantidadMinima", l.CantidadMinima);
                    cmd.Parameters.AddWithValue("@PrecioCompra", l.PrecioCompra);
                    cmd.Parameters.AddWithValue("@ConFechaVencimiento", l.ConFechaVencimiento);
                    cmd.Parameters.AddWithValue("@IdMoneda", l.IdMoneda);
                    cmd.Parameters.AddWithValue("@IdLineaArticulo", l.IdLineaArticulo);
                    cmd.Parameters.AddWithValue("@IdGrupoArticulo", l.IdGrupoArticulo);
                    cmd.Parameters.AddWithValue("@IdUnidadMedida", l.IdUnidadMedida);
                    cmd.Parameters.AddWithValue("@IdSerialización", l.IdSerialización);
                    cmd.Parameters.AddWithValue("@IdMarca", l.IdMarca);
                    cmd.Parameters.AddWithValue("@IdColor", l.IdColor);
                    cmd.Parameters.AddWithValue("@Estante", l.Estante);
                    cmd.Parameters.AddWithValue("@Nivel", l.Nivel);
                    cmd.Parameters.AddWithValue("@FechaRegistro", l.FechaRegistro);
                    cmd.Parameters.AddWithValue("@EstadoRegistro", l.EstadoRegistro);

                    await con.OpenAsync();

                    if (t == "c")
                    {
                        // Si es una operación de inserción, obtenemos el nuevo ID
                        object result = await cmd.ExecuteScalarAsync();
                        l.IdInsumo = Convert.ToInt32(result);
                    }
                    else if (t == "u")
                    {
                        // Si es una operación de actualización, ejecutamos la consulta directamente
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            return l;
        }
    }

}
