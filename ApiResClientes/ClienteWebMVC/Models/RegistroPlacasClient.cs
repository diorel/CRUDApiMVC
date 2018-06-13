using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using System.Net.Http.Headers;

using System.Web;


namespace ClienteWebMVC.Models
{
    public class RegistroPlacasClient
    {

        // nueva url http://localhost:22703/api/RegistroPlacas
        private string Base_URL = "http://localhost:22703/api/";


        // para que funcione el ReadAsAsync sera nesesario  desgargarlo por que no esta en el framework 
        // checar esta liga https://www.nuget.org/packages/Microsoft.AspNet.WebApi.Client/


        // Metodo para obtener todos los datos 

        public IEnumerable<RegistroPlacas> findAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                //client.BaseAddress = new Uri("http://localhost:22703/api/RegistroPlacas");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RegistroPlacas").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<RegistroPlacas>>().Result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Metodo para obtener solo un registro 
        
        public RegistroPlacas find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("RegistroPlacas/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<RegistroPlacas>().Result;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metodo para crar un registro  

        public bool Create(RegistroPlacas registroplacas)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("RegistroPlacas", registroplacas).Result;
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Metodo para crar un registro  nuevo

        public bool Edit(RegistroPlacas registroplacas)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("RegistroPlacas/" + registroplacas.IdRegistro, registroplacas).Result;
                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //Metodo para elimianr un registro

        public bool Delate(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Base_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync("RegistroPlacas/" + id).Result;
                return response.IsSuccessStatusCode;

            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}