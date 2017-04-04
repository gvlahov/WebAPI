using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAPIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("  \"apiToken\": \"2C8BF34D-7E97-BB65-2C3C-179BE9D6D4C4\",");
            stringBuilder.AppendLine("  \"bcmContactInfo\": {");
            stringBuilder.AppendLine("    \"firstName\": \"Име\",");
            stringBuilder.AppendLine("    \"middleName\": \"Презиме\",");
            stringBuilder.AppendLine("    \"lastName\": \"Фамилия\",");
            stringBuilder.AppendLine("    \"phone\": \"359123456\",");
            stringBuilder.AppendLine("    \"bcmContactId\": 123456,");
            stringBuilder.AppendLine("    \"bcmLanguageId\": 2,");
            stringBuilder.AppendLine("    \"email\": \"sales@varnadatacenter.com\",");
            stringBuilder.AppendLine("    \"company\": \"Варна Дейта Център\",");
            stringBuilder.AppendLine("    \"country\": \"България\",");
            stringBuilder.AppendLine("    \"city\": \"Варна\",");
            stringBuilder.AppendLine("    \"streetAddress\": \"ул. Н/михайловски 18\"");
            stringBuilder.AppendLine("  },");
            stringBuilder.AppendLine("  \"bcmEventInfo\": {");
            stringBuilder.AppendLine("    \"operatorId\": \"D7A7FB71-AA17-4097-A6D5-CED720908D50\",");
            stringBuilder.AppendLine("    \"eventHistoryId\": 123456,");
            stringBuilder.AppendLine("    \"eventType\": 1");
            stringBuilder.AppendLine("  },");
            stringBuilder.AppendLine("  \"serviceInfo\": {");
            stringBuilder.AppendLine("    \"brand\": \"Марка\",");
            stringBuilder.AppendLine("    \"model\": \"Модел\",");
            stringBuilder.AppendLine("    \"guarantee\": true,");
            stringBuilder.AppendLine("    \"description\": \"Описание на повредата и др.\"");
            stringBuilder.AppendLine("  }");
            stringBuilder.AppendLine("}");

            textBoxRequest.Text = stringBuilder.ToString();
        }

        private async void buttonCall_Click(object sender, EventArgs e)
        {
            buttonCall.Enabled = false;

            textBoxResponse.Text = string.Empty;

            string uri = textBoxURL.Text;
            string jsonResponse = string.Empty;
            string jsonRequest = textBoxRequest.Text;

            HttpClient httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(30);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //Task<HttpResponseMessage> responseTask =  httpClient.PostAsync(uri, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));

            // await and process request
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(uri, new StringContent(jsonRequest, Encoding.UTF8, "application/json"));
                //HttpResponseMessage response = await responseTask;
                response.EnsureSuccessStatusCode();    // throw if not a success code.
                jsonResponse = await response.Content.ReadAsStringAsync();
            }
            //catch (HttpRequestException ex)
            catch (Exception ex)
            {
                textBoxResponse.Text = ex.Message;
            }
            finally
            {
                httpClient.Dispose();
            }

            if (jsonResponse != string.Empty)
            {
                textBoxResponse.Text = jsonResponse;
            }

            tabControlPages.SelectedIndex = 1;

            buttonCall.Enabled = true;
        }
    }
}
