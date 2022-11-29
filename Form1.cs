using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Unicode;
using SW_APIS_CLIENT.Models;

namespace SW_APIS_CLIENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetInvoiceByUuidButton_Click(object sender, EventArgs e)
        {
            var uri = @"http://api.test.sw.com.mx/datawarehouse/v1/live/246b0828-298e-4f30-bac5-10c1056d61f2";
            var token =
                "T2lYQ0t4L0RHVkR4dHZ5Nkk1VHNEakZ3Y0J4Nk9GODZuRyt4cE1wVm5tbXB3YVZxTHdOdHAwVXY2NTdJb1hkREtXTzE3dk9pMmdMdkFDR2xFWFVPUXpTUm9mTG1ySXdZbFNja3FRa0RlYURqbzdzdlI2UUx1WGJiKzViUWY2dnZGbFloUDJ6RjhFTGF4M1BySnJ4cHF0YjUvbmRyWWpjTkVLN3ppd3RxL0dJPQ.T2lYQ0t4L0RHVkR4dHZ5Nkk1VHNEakZ3Y0J4Nk9GODZuRyt4cE1wVm5tbFlVcU92YUJTZWlHU3pER1kySnlXRTF4alNUS0ZWcUlVS0NhelhqaXdnWTRncklVSWVvZlFZMWNyUjVxYUFxMWFxcStUL1IzdGpHRTJqdS9Zakw2UGRnSkpzVGJmUmJtMnkrRVVIWnJrWnlvZXBjV2twVXR3WEUrM2ZlY2F5QzBCL3JxZFduV0FMY3lDTnlQR3RONHcvS1VQcEVEblYzd0pZSUwvZ0Z6RnVIbkcreklaZE03RHl2eVJTMWkyQ2tpOHFyM2cxc2txOUlsQTdtTjNiYWd2dnN3R09GamJYL3Ywdk9kcTF4K0p2SE9pN1J3ZUJPcmFXcXpFUnUwOURiMHV4NGEwTHp0WkZabjV0UmxsUVlSM2pzQk1HNGI2dU4zWFFlU1ZCdWVoYkVOcjB1cXd5OGNENTVHdW1oL0VEVEQ5M3UyclFNMmpTNmtzQitJa0hEa2tiOTM4cWVHQ2F0bXJqRyt2Y2psQXdkUmc0TjRjbHY3S1hRTXdUelVabkIvME1PRmlPTE9UNFl6QnNaOU1KWDRIa252WUFNbWU3K3FHa0xSbzBkSHJzb0ViYVlwZGVzZlpBY1ppQzZoZG81NU11elJMdXpVUm02bEs0K2RoK204YVM.92uuBpBJP9rgFf8694IodP3iPQuhS9yYwqGvD4CpysM";

            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            request.Headers.Add("Accept", "application/json");
            var response = await httpClient.SendAsync(request);


            var responseObject =  await response.Content.ReadFromJsonAsync<StorageResponse>(); //Error caracteres escapados que deforman el JSON.

            
            MessageBox.Show($"StatusCode {response.StatusCode} reason {response.ReasonPhrase}");
        }
    }
}