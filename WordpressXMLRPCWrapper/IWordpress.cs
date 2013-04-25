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
    public interface IWordpress : IXmlRpcProxy
    {
        [XmlRpcMethod("wp.getUsersBlogs")]
        RPCUserBlog[] GetUsersBlogs(string username, string password);

        [XmlRpcMethod("wp.getTerms")]
        RPCTerm[] GetTerms(int blogId, string username, string password, string taxonomy, RPCTermFilter? filter);

        [XmlRpcMethod("wp.getPosts")]
        RPCPost[] GetPosts(int blogId, string username, string password, RPCPostFilter? filter, RPCCustomField[] fields);

        [XmlRpcMethod("wp.getPostTypes")]
        XmlRpcStruct GetPostTypes(int blogId, string username, string password, object filter, object[] fields);

        [XmlRpcMethod("wp.deletePost")]
        bool DeletePost(int blogId, string username, string password, int postId);
    }
}
