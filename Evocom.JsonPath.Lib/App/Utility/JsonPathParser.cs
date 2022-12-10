using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Evocom.JsonPath.Lib.App.Utility
{
    public static class JsonPathParser
    {
        public static void ReadAndParseJson()
        {
            var jobjectData = @"[
                                      {

                                        ""field"": {

                                          ""name"": ""Title""

                                        },

                                        ""value"": ""Hello world""

                                      },

                                      {

                                        ""field"": {

                                          ""name"": ""Description""

                                        },

                                        ""value"": ""some text""

                                      },

                                      {

                                        ""field"": {

                                          ""name"": ""Information""

                                        },

                                        ""value"": ""and even more text""

                                      }

                                    ]";
            

            IList<string> parsedObjectData = JsonNetValueSystem.ConvertJArrayToList(jobjectData);

            for (int i = 0; i < parsedObjectData.Count; i++)
            {
                Console.WriteLine("parsedObjectData: {0}", parsedObjectData[i].ToString());
            }

            Console.ReadLine();
        }

       
    }
}
