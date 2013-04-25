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

namespace WordpressXMLRPCWrapper
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public struct RPCTermFilter
    {
        [XmlRpcMember("number")]
        public int? Number;

        [XmlRpcMember("offset")]
        public int? Offset;

        [XmlRpcMember("orderby")]
        public string OrderBy;

        [XmlRpcMember("order")]
        public string Order;

        [XmlRpcMember("hide_empty")]
        public bool? HideEmpty;

        [XmlRpcMember("search")]
        public string Search;
    }
}
