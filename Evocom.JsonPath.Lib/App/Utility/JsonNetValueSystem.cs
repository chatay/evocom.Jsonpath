using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Evocom.JsonPath.Lib.App.Utility
{
    public static class JsonNetValueSystem
    {
        public static List<string> InvalidJsonElements;
        public static IList<string> ConvertJArrayToList(this string jsonString)
        {
            InvalidJsonElements = null;
            var array = JArray.Parse(jsonString);
            List<string> objectsList = new List<string>();

            foreach (var item in array.Children<JObject>())

            {
                try
                {
                    var fieldName = item["field"]["name"].ToString();
                    var fieldValue = item["value"].ToString();
                    objectsList.AddRange(new List<string>() { fieldName, fieldValue });
                }
                catch (Exception ex)
                {
                    InvalidJsonElements ??= new List<string>();
                    InvalidJsonElements.Add(item.ToString());
                }
            }

            return objectsList;
        }
    }
}
