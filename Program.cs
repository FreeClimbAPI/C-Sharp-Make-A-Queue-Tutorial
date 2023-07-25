using System;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace CreateQueue
{
  public class Program
  {

    static void Main()
    {
      Configuration config = new Configuration();
      config.BasePath = "https://www.freeclimb.com/apiserver";

      string accountId = System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
      string apiKey = System.Environment.GetEnvironmentVariable("API_KEY");
      string alias = "My_First_Queue";
      // Configure HTTP basic authorization: fc
      config.Username = accountId;
      config.Password = apiKey;
      DefaultApi freeclimbClient = new DefaultApi(config);
      QueueRequest queueRequest = new QueueRequest(alias);

       try
        {
          // Invoke method to create queue metadata
          QueueResult result = freeclimbClient.CreateAQueue(queueRequest);
          System.Console.WriteLine(result);
        }
        catch(ApiException  e)
        {
          System.Console.WriteLine("Exception when calling DefaultApi.CreateAQueue: " + e.Message);
          System.Console.WriteLine("Status Code: "+ e.ErrorCode);
          System.Console.WriteLine(e.StackTrace);
        }
    }
  }
}
