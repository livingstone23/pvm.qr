using System.Security.Cryptography;
using System.Text;

namespace PVM.ApiMobile.Generic;

public class Cifrado
{
    public static string cifrarCadena(string cadena)
    {
        SHA256Managed sha = new SHA256Managed();
        byte[] bytecadena = Encoding.Default.GetBytes(cadena);
        byte[] bytecifrado = sha.ComputeHash(bytecadena);
        return BitConverter.ToString(bytecifrado).Replace("-", "");

    }
}