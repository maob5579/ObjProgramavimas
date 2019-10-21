using Newtonsoft.Json;
using PrototypeDemo.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class MoodDetection
    {
        private const string subscriptionKey = "850a4b31e6d546b3938f994074acad6f";
        //private const string uriBase = "https://westcentralus.api.cognitive.microsoft.com/face/v1.0/detect";
        private const string uriBase = "https://faceapieservice.cognitiveservices.azure.com/face/v1.0/detect";

        public async Task<MoodModel> GetEmotions(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new MoodModel();
            }

            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

                string requestParameters = "returnFaceId=false&returnFaceLandmarks=false" +
                    "&returnFaceAttributes=emotion";

                // Assemble the URI for the REST API Call.
                string uri = uriBase + "?" + requestParameters;

                HttpResponseMessage response;

                byte[] byteData = GetImageAsByteArray(filePath);

                using (ByteArrayContent content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

                    // Execute the REST API call.
                    response = await client.PostAsync(uri, content);

                    // Get the JSON response.
                    string contentString = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON string
                    dynamic jsonObj = JsonConvert.DeserializeObject(contentString.Substring(1, contentString.Length - 2));

                    MoodModel moodModel = new MoodModel();

                    //wanna vomit from the code below
                    moodModel.Anger = jsonObj.faceAttributes.emotion.anger.Value;
                    moodModel.Contempt = jsonObj.faceAttributes.emotion.contempt.Value;
                    moodModel.Disgust = jsonObj.faceAttributes.emotion.disgust.Value;
                    moodModel.Fear = jsonObj.faceAttributes.emotion.fear.Value;
                    moodModel.Happiness = jsonObj.faceAttributes.emotion.happiness.Value;
                    moodModel.Neutral = jsonObj.faceAttributes.emotion.neutral.Value;
                    moodModel.Sadness = jsonObj.faceAttributes.emotion.sadness.Value;
                    moodModel.Surprise = jsonObj.faceAttributes.emotion.surprise.Value;

                    return moodModel;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message + "\nPress Enter to exit...\n");
                return new MoodModel();
            }
        }

        static byte[] GetImageAsByteArray(string imageFilePath)
        {
            using (FileStream fileStream =
                new FileStream(imageFilePath, FileMode.Open, FileAccess.Read))
            {
                BinaryReader binaryReader = new BinaryReader(fileStream);
                return binaryReader.ReadBytes((int)fileStream.Length);
            }
        }
    }
}
