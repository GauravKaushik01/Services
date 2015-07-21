﻿using AAGJKPRTServices.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace AAGJKPRTServices
{
    [ServiceContract]
    public interface IService1
    {

        // TODO: Add your service operations here
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetUserlist/", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UserInfoDataContract GetUserlist();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Getuserinfo/{username}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UserInfoDataContract Getuserinfo(string username);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetbothUsers/{username1},{username2}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        UserInfoDataContract GetbothUsers(string username1, string username2);
    }
}
