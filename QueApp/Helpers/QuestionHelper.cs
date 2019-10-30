﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QueApp
{
    public class QuestionHelper
    {       
        //private static string SetQuestion()
        //{
        //    var request = WebRequest.Create("https://queapp.azurewebsites.net/api/SetQuestion?code=xbd/hedegNoJq0reGeTI1SaTk8S0LvCjbPsev2Nc1xr6tmYl14UtnA==");
        //    request.ContentType = "application/json";
        //    request.Method = "POST";
        //    var response = (HttpWebResponse)request.GetResponse();

        //    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //    return responseString;
        //}
        public static void SetQuestion(string rowKey, string partitionKey,bool update, string title,string description, string category1, string category2, string category3,string question1, string question2,string answer, string askedBy,string answeredBy,bool isActive)
        {
            var request = WebRequest.Create("https://queapp.azurewebsites.net/api/SetQuestion?code=xbd/hedegNoJq0reGeTI1SaTk8S0LvCjbPsev2Nc1xr6tmYl14UtnA==");
            request.ContentType = "application/json";
            request.Method = "POST";

            var setQuestionRequest = new 
            {
                RowKey = rowKey,
                PartitionKey = partitionKey,
                Update = update,
                Title = title,
                Description = description,
                Category1 = category1,
                Category2 = category2,
                Category3 = category3,
                Question1 = question1,
                Question2 = question2,
                Answer = answer,
                AskedBy = askedBy,
                AnsweredBy = answeredBy,
                IsActive = isActive
            };
            var data = JsonConvert.SerializeObject(setQuestionRequest).ToString();
            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.WriteLine(data);
            }

            var response = (HttpWebResponse)request.GetResponse();

            //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

    }
}
