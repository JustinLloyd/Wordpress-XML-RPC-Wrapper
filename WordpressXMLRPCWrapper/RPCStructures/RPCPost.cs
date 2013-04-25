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
    public struct RPCPost
    {
        [XmlRpcMember("post_id")]
        public string ID;

        [XmlRpcMember("post_title")]
        public string Title;

        //[XmlRpcMember("post_date")]
        //public DateTime Date;

        //[XmlRpcMember("post_date_gmt")]
        //public DateTime DateGMT;

        //[XmlRpcMember("post_modified")]
        //public DateTime Modified;

        //[XmlRpcMember("post_modified_gmt")]
        //public DateTime ModifiedGMT;

        [XmlRpcMember("post_status")]
        public string Status;

        [XmlRpcMember("post_type")]
        public string Type;

        [XmlRpcMember("post_format")]
        public string Format;

        [XmlRpcMember("post_name")]
        public string Name;

        [XmlRpcMember("post_author")]
        public string AuthorID;

        [XmlRpcMember("post_password")]
        public string Password;

        [XmlRpcMember("post_excerpt")]
        public string Excerpt;

        [XmlRpcMember("post_content")]
        public string Content;

        [XmlRpcMember("post_parent")]
        public string Parent;

        [XmlRpcMember("post_mime_type")]
        public string MIMEType;

        [XmlRpcMember("link")]
        public string Link;

        [XmlRpcMember("guid")]
        public string GUID;

        [XmlRpcMember("menu_order")]
        public int MenuOrder;

        [XmlRpcMember("comment_status")]
        public string CommentStatus;

        [XmlRpcMember("ping_status")]
        public string PingStatus;

        [XmlRpcMember("sticky")]
        public bool Sticky;

        [XmlRpcMember("post_thumbnail")]
        public object Thumbnail;

        //[XmlRpcMember("terms")]
        //public Term[] Terms;

        //[XmlRpcMember("custom_fields")]
        //public RPCCustomField[] CustomFields;

        //[XmlRpcMember("enclosure")]
        //public RPCEnclosure Enclosure;
    }
}
