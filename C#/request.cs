    //Our Handle Request gets Created.
    using System;
    using System.Net.Http;
    using System.Net.Http.Json;
    using NaniAPI_Request_Example;

    //Make the request and make the actually call.
    using (var client = new HttpClient())
    {
        try
        {
            //Our nani API token which we get on https://nani.red/dashboard/
            var nani_API_token = "";
            
            //Get the Json result from the website
            var response = await client.GetFromJsonAsync<NaniRedApi>(
                string.Format("https://nani.red/api/gif/{0}/token={1}&type={2}/", "cuddle",
                    nani_API_token, new int[] { })
            );

            //check if the response is not null
            if (response is not null)
            {
                //print our final image into the Console.
                Console.WriteLine($"Image is | {response.Response}");
            }
        }
        catch (Exception e)
        {
            //Catches an Exception and print it into the console.
            Console.WriteLine(e);
            throw;
        }
    }
