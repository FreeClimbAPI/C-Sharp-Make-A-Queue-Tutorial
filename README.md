# C# - Make a Queue Tutorial

This project serves as a guide to help you build an application with FreeClimb View this tutorial on [FreeClimb.com](https://docs.freeclimb.com/docs/make-a-queue#section-c). Specifically, the project will:

- Makes a call queue
- Get the details of the queue

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the Tutorial

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb
   ```

2. Configure environment variables

   | ENV VARIABLE | DESCRIPTION                                                                                                                           |
   | ------------ | ------------------------------------------------------------------------------------------------------------------------------------- |
   | ACCOUNT_ID   | Account ID which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard |
   | API_KEY      | API key which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard    |

## Runnning the Tutorial

1. Run the application using command:

   ```bash
   $  dotnet run
   ```

- If you're having issues running the application, remove any other instances of the enviornment varibles being set and paste the ACCOUNT_ID and API_KEY values directly in those fields as strings.

```
BEFORE:
   string accountId = System.Environment.GetEnvironmentVariable("ACCOUNT_ID");
   string apiKey = System.Environment.GetEnvironmentVariable("API_KEY");

AFTER:
   string accountId = "ACCOUNT_ID";
   string apiKey = "API_KEY";
```

## Getting Help

If you are experiencing difficulties, [contact support](https://freeclimb.com/support).
