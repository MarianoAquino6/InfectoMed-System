using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Herramientas
{
    internal static class Hash
    {
        /// <summary>
        /// Calcula el hash SHA-256 de una contraseña y lo devuelve como una cadena hexadecimal.
        /// </summary>
        /// <param name="password">Contraseña a ser hasheada.</param>
        /// <returns>Hash SHA-256 de la contraseña como una cadena hexadecimal.</returns>
        internal static string HashPassword(string password)
        {
            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    // Convertir la contraseña en bytes
                    byte[] bytes = Encoding.UTF8.GetBytes(password);

                    // Calcular el hash
                    byte[] hash = sha256.ComputeHash(bytes);

                    // Convertir el hash en una cadena hexadecimal
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        stringBuilder.Append(hash[i].ToString("x2"));
                    }

                    return stringBuilder.ToString();
                }
            }
            catch (Exception ex)
            {
                RegistroExcepciones.RegistrarExcepcion(ex);
                return string.Empty;
            }
        }
    }
}
