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
    public struct RPCTerm
    {
        [XmlRpcMember("term_id")]
        public string ID;

        [XmlRpcMember("name")]
        public string Name;

        [XmlRpcMember("slug")]
        public string Slug;

        [XmlRpcMember("term_group")]
        public string TermGroup;

        [XmlRpcMember("term_taxonomy_id")]
        public string TermTaxonomyID;

        [XmlRpcMember("taxonomy")]
        public string Taxonomy;

        [XmlRpcMember("description")]
        public string Description;

        [XmlRpcMember("parent")]
        public string Parent;

        [XmlRpcMember("count")]
        public int Count;
    }
}
