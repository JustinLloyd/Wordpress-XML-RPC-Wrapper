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

namespace WordpressXMLRPCWrapper
{
    public struct Post
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime DateGMT { get; private set; }
        public DateTime Modified { get; private set; }
        public DateTime ModifiedGMT { get; private set; }
        public string Status { get; private set; }
        public string Type { get; private set; }
        public string Format { get; private set; }
        public string Name { get; private set; }
        public int AuthorID { get; private set; }
        public string Password { get; private set; }
        public string Excerpt { get; private set; }
        public string Content { get; private set; }
        public string Parent { get; private set; }
        public string MIMEType { get; private set; }
        public string Link { get; private set; }
        public string GUID { get; private set; }
        public int MenuOrder { get; private set; }
        public string CommentStatus { get; private set; }
        public string PingStatus { get; private set; }
        public bool Sticky { get; private set; }
        public object Thumbnail { get; private set; }
        public Term[] Terms { get; private set; }
        public RPCCustomField[] CustomFields { get; private set; }
        public RPCEnclosure Enclosure { get; private set; }
    }
}
