using RestSharp;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

public class DailyAPIClient
{
    private readonly string apiKey = "";  // pegar apikey
    private readonly string baseUrl = "https://api.daily.co/v1/";

    public string CreateRoom()
    {
        try
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest("rooms", Method.Post);
            request.AddHeader("Authorization", $"Bearer {apiKey}");
            request.AddJsonBody(new { properties = new { enable_screenshare = true } });

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
                return jsonResponse?.name;
            }
            else
            {
                MessageBox.Show($"Error: {response.ErrorMessage}");
                return null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Exception: {ex.Message}");
            return null;
        }
    }

    public string GetRoomUrl(string roomName)
    {
        return $"https://your-domain.daily.co/{roomName}";
    }
}
