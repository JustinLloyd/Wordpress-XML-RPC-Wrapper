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
using CookComputing.XmlRpc;
using WordpressXMLRPCWrapper;
using AutoMapper;

namespace WordpressXMLRPCWrapper
{
    public class Wordpress
    {
        private int m_numberOfPostsToRetrieveAtOnce = 25;
        protected string m_username = String.Empty;
        protected string m_password = String.Empty;
        protected Uri m_rpcUrl;
        protected IWordpress m_rpcProxy;
        protected int m_defaultBlogId;

        public int PostsToRetrieveAtOnce
        {
            get
            {
                return m_numberOfPostsToRetrieveAtOnce;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Number of posts to retrieve must be greater than zero.");
                }

                m_numberOfPostsToRetrieveAtOnce = value;
            }

        }

        public string Username
        {
            get
            {
                return m_username;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Username cannot be null. To specify no user name, set the Username property to String.Empty");
                }

                m_username = value;
            }

        }

        public string Password
        {
            get
            {
                return m_password;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Password cannot be null. To specify no password, set the Password property to String.Empty");
                }

                m_password = value;
            }

        }

        public Uri RPCUrl
        {
            get
            {
                return m_rpcUrl;
            }

            set
            {
                m_rpcUrl = value;
                m_rpcProxy.Url = m_rpcUrl.ToString();
            }

        }

        public int DefaultBlogId
        {
            get
            {
                return m_defaultBlogId;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Wordpress blog ID is always greater than zero.");
                }

                m_defaultBlogId = value;
                try
                {
                    this.RPCUrl = UsersBlogs.ElementAt(m_defaultBlogId).XMLRPCUrl;
                }

                catch
                {
                    // do nothing
                }

            }

        }

        private void RegisterMaps()
        {
            Mapper.CreateMap<RPCUserBlog, UserBlog>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => int.Parse(src.ID)))
                .ForMember(dest => dest.XMLRPCUrl, opt => opt.MapFrom(src => new Uri(src.XMLRPCUrl)))
                .ForMember(dest => dest.Url, opt => opt.MapFrom(src => new Uri(src.Url)));

            Mapper.CreateMap<TermFilter, RPCTermFilter>();

            Mapper.CreateMap<RPCPost, Post>();

            Mapper.CreateMap<PostFilter, RPCPostFilter>();

            Mapper.CreateMap<CustomField, RPCCustomField>();

            Mapper.CreateMap<XmlRpcStruct, PostType>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src["name"]))
                .ForMember(dest => dest.Label, opt => opt.MapFrom(src => src["label"]));

            Mapper.CreateMap<RPCTerm, Term>()
                .ForMember(dest => dest.ID, opt => opt.MapFrom(src => int.Parse(src.ID)))
                .ForMember(dest => dest.TermTaxonomyID, opt => opt.MapFrom(src => int.Parse(src.TermTaxonomyID)));

            Mapper.CreateMap<PostStatus, string>()
                .ConvertUsing(src => src.ToRPC());

            Mapper.CreateMap<PostOrderBy, string>()
                .ConvertUsing(src => src.ToRPC());

            Mapper.CreateMap<Ordering, string>()
                .ConvertUsing(src => src.ToRPC());
        }

        public Wordpress()
        {
            m_rpcProxy = XmlRpcProxyGen.Create<IWordpress>();
            RegisterMaps();
        }

        public Wordpress(Uri url)
            : this()
        {
            this.RPCUrl = url;
        }

        public Wordpress(Uri url, string username, string password)
            : this(url)
        {
            this.Username = username;
            this.Password = password;
            try
            {
                UserBlog firstBlog = UsersBlogs.First();
                m_defaultBlogId = firstBlog.ID;
                RPCUrl = firstBlog.XMLRPCUrl;
            }

            catch
            {
                DefaultBlogId = 1;
            }

        }

        public Wordpress(Uri url, string username, string password, int defaultBlogId)
            : this(url)
        {
            this.Username = username;
            this.Password = password;
            DefaultBlogId = defaultBlogId;
        }

        public IWordpress Proxy
        {
            get
            {
                return m_rpcProxy;
            }

        }

        public IEnumerable<Post> Posts
        {
            get
            {
                PostFilter filter = new PostFilter()
                {
                    Number = PostsToRetrieveAtOnce,
                    Offset = 0,
                    Order = Ordering.Ascending,
                    OrderBy = PostOrderBy.None,
                    Type = "post",
                    Status = new PostStatus[] { PostStatus.Any },
                };

                return FilteredPosts(filter);
            }

        }

        public IEnumerable<PostType> PostTypes
        {
            get
            {
                var rpcPostTypesContainer = m_rpcProxy.GetPostTypes(m_defaultBlogId, m_username, m_password, null, null);
                IEnumerable<XmlRpcStruct> rpcPostTypes = rpcPostTypesContainer.Values.Cast<XmlRpcStruct>().ToList();
                IEnumerable<PostType> postTypes = Mapper.Map<IEnumerable<XmlRpcStruct>, IEnumerable<PostType>>(rpcPostTypes);

                return postTypes;
            }

        }

        public IEnumerable<Post> FilteredPosts(PostFilter filter, CustomField[] fields = null)
        {
            RPCPostFilter rpcFilter = Mapper.Map<PostFilter, RPCPostFilter>(filter);
            RPCCustomField[] rpcFields = null;
            if ((fields != null) && (fields.Length > 0))
            {
                rpcFields = Mapper.Map<IEnumerable<CustomField>, IEnumerable<RPCCustomField>>(fields).ToArray();
            }

            RPCPost[] rpcPosts = m_rpcProxy.GetPosts(m_defaultBlogId, m_username, m_password, rpcFilter, rpcFields);
            while ((rpcPosts != null) && (rpcPosts.Length > 0))
            {
                foreach (RPCPost rpcPost in rpcPosts)
                {
                    yield return Mapper.Map<RPCPost, Post>(rpcPost);
                }

                rpcFilter.Offset += rpcFilter.Number;
                rpcPosts = m_rpcProxy.GetPosts(m_defaultBlogId, m_username, m_password, rpcFilter, rpcFields);
            }

        }

        public IEnumerable<UserBlog> UsersBlogs
        {
            get
            {
                RPCUserBlog[] usersBlogs = m_rpcProxy.GetUsersBlogs(m_username, m_password);

                return Mapper.Map<IEnumerable<RPCUserBlog>, IEnumerable<UserBlog>>(usersBlogs);
            }

        }

    }

}
