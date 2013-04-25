/*
 *                    DO WHATEVER PUBLIC LICENSE
 *   TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION
 *
 * 0. You can do whatever you want to with the work.
 * 1. You cannot stop anybody from doing whatever they want to with the work.
 * 2. You cannot revoke anybody elses DO WHATEVER PUBLIC LICENSE in the work.
 *
 * This program is free software. It comes without any warranty, to
 * the extent permitted by applicable law. You can redistribute it
 * and/or modify it under the terms of the DO WHATEVER PUBLIC LICENSE
 * 
 * Software originally created by Justin Lloyd @ http://otakunozoku.com/
 *
 */

using System;
using CookComputing.XmlRpc;
using System.Collections.Generic;

namespace WordpressXMLRPCWrapper
{

    public struct RPCPostFilter
    {
        [XmlRpcMember("post_type")]
        public string Type;

        [XmlRpcMember("post_status")]
        public string[] Status;

        [XmlRpcMember("number")]
        public int Number;

        [XmlRpcMember("offset")]
        public int Offset;

        [XmlRpcMember("orderby")]
        public string OrderBy;

        [XmlRpcMember("order")]
        public string Order;

        //public RPCPostFilter()
        //{
        //    Type = new string[] { "post", "page" };
        //    Status = new string[] { "any" };
        //    Number = 20;
        //    Offset = 0;
        //    OrderBy = "asc";
        //    Order = "none";
        //}

    //    [XmlRpcMember("hide_empty")]
    //    public bool HideEmpty;

    //    [XmlRpcMember("search")]
    //    public string Search;
    }
}
