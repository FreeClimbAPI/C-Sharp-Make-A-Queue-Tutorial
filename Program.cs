using com.freeclimb.api;
using com.freeclimb.api.queue;
namespace CreateQueue
{
  class Program
  {
    static string getFreeClimbAccountId()
    {
      return System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
    }

    static string getFreeClimbAccountToken()
    {
      return System.Environment.GetEnvironmentVariable("AUTH_TOKEN");
    }

    static void Main(string[] args)
    {
      string alias = "My_First_Queue";

      QueueOptions options = new QueueOptions();
      options.setAlias(alias); // Set the optional alias

      // Create FreeClimbClient object
      FreeClimbClient client = new FreeClimbClient(getFreeClimbAccountId(),
                                           getFreeClimbAccountToken());

      // Invoke method to create queue metadata
      Queue queue = client.getQueuesRequester.create(options);
    }
  }
}
