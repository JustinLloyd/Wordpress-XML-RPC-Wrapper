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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordpressXMLRPCWrapper;

namespace WordpressDemoHarness
{
    class Program
    {
        private const string UserName = "YOUR_USERNAME";
        private const string Password = "YOUR_PASSWORD";
        private const string XMLRPCUrl = "YOUR_WORDPRESS_XMLRPC_URL";

        static void Main(string[] args)
        {
            Wordpress wpContext = new Wordpress(new Uri(XMLRPCUrl), UserName, Password);
            Console.WriteLine("Users Blogs\n===========");
            IEnumerable<UserBlog> blogs = wpContext.UsersBlogs;
            foreach (var blog in blogs)
            {
                Console.WriteLine(String.Format("{0} - {1}", blog.ID, blog.Name));
            }

            Console.WriteLine("\nPost Types\n==========");
            var postTypes = wpContext.PostTypes;
            foreach (var postType in postTypes)
            {
                Console.WriteLine(String.Format("{0} - {1}", postType.Name, postType.Label));
            }

            Console.WriteLine("\nPosts\n=====");
            wpContext.PostsToRetrieveAtOnce = 100;
            var posts = wpContext.Posts;
            foreach (var post in posts)
            {
                Console.WriteLine(String.Format("{0} - ({2}) {1}", post.ID, post.Title, post.Status));
            }

            Console.WriteLine("\nPages\n=====");
            var pages = wpContext.FilteredPosts(new PostFilter() { Type = "page", Number = 20 });
            foreach (var page in pages)
            {
                Console.WriteLine(String.Format("{0} - ({2}) {1}", page.ID, page.Title, page.Status));
            }


        }

    }

}
