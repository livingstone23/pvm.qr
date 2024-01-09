using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PVM.Mobile.Generic;

public class Http
{

    public static async Task<int> Post<T>(string url, T obj)
    {
        try
        {
            var cliente = new HttpClient();
            var response = await cliente.PostAsJsonAsync<T>(url, obj);
            if (response.IsSuccessStatusCode)
            {
                string cadena = await response.Content.ReadAsStringAsync();
                return int.Parse(cadena);
            }
            else
            {
                return 0;
            }

        }
        catch (Exception ex)
        {
            return 0;
        }

    }

    public static async Task<string> PostString<T>(string url, T obj)
    {
        try
        {
            var cliente = new HttpClient();
            var response = await cliente.PostAsJsonAsync<T>(url, obj);
            if (response.IsSuccessStatusCode)
            {
                string cadena = await response.Content.ReadAsStringAsync();
                return cadena;
            }
            else
            {
                return "";
            }

        }
        catch (Exception ex)
        {
            return "";
        }

    }

    public static ImageSource convertir(string value)
    {
        try
        {
            string valor = (string)value;
            byte[] buffer = System.Convert.FromBase64String(valor);
            return ImageSource.FromStream(() => new MemoryStream(buffer));
        }
        catch (Exception ex)
        {
            return "" + ex.Message;
        }

    }


    public static async Task<int> Delete(string url)
    {
        HttpClient cliente = new HttpClient();
        var rpta = await cliente.DeleteAsync(url);
        if (!rpta.IsSuccessStatusCode) return 0;
        else
        {
            //Cadena(1 -> Exitoso , 0->Error) ->int ""
            var result = await rpta.Content.ReadAsStringAsync();
            return int.Parse(result);
        }


    }

    //Retorne la data
    public static async Task<List<T>> GetAll<T>(string url)
    {
        HttpClient cliente = new HttpClient();
        var rpta = await cliente.GetAsync(url);
        if (!rpta.IsSuccessStatusCode) return new List<T>();
        else
        {
            //Como String
            var result = await rpta.Content.ReadAsStringAsync();
            List<T> l = JsonConvert.DeserializeObject<List<T>>(result);
            return l;
        }

    }


    public static async Task<T> Get<T>(string url)
    {
        HttpClient cliente = new HttpClient();
        var rpta = await cliente.GetAsync(url);

        //Como String
        var result = await rpta.Content.ReadAsStringAsync();
        T l = JsonConvert.DeserializeObject<T>(result);
        return l;


    }

    public static async Task<string> GetString(string url)
    {
        try
        {
            HttpClient cliente = new HttpClient();
            var rpta = await cliente.GetAsync(url);
            if (rpta.IsSuccessStatusCode)
            {
                //Como String
                var result = await rpta.Content.ReadAsStringAsync();

                return result;
            }
            else
            {
                return "";
            }
        }
        catch (Exception ex)
        {
            return "";

        }




    }

    public static async Task<int> GetInt(string url)
    {
        try
        {
            HttpClient cliente = new HttpClient();
            var rpta = await cliente.GetAsync(url);
            if (rpta.IsSuccessStatusCode)
            {
                //Como String
                var result = await rpta.Content.ReadAsStringAsync();

                return int.Parse(result);
            }
            else
            {
                return 0;
            }
        }
        catch (Exception ex)
        {
            return 0;

        }




    }

}

