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
    public struct RPCPostType
    {
        [XmlRpcMember("name")]
        public string Name;

        [XmlRpcMember("label")]
        public string Label;

        [XmlRpcMember("hierarchical")]
        public bool Hierarchical;

        [XmlRpcMember("public")]
        public bool IsPublic;

        [XmlRpcMember("show_ui")]
        public bool ShowUI;

        [XmlRpcMember("_builtin")]
        public bool BuiltIn;

        [XmlRpcMember("has_archive")]
        public bool HasArchive;

        [XmlRpcMember("supports")]
        public RPCPostTypeSupports Supports;

        [XmlRpcMember("labels")]
        public XmlRpcStruct Labels;

        [XmlRpcMember("cap")]
        public XmlRpcStruct Cap;

        [XmlRpcMember("map_meta_cap")]
        public bool MapMetaCap;

        [XmlRpcMember("menu_position")]
        public int MenuPosition;

        [XmlRpcMember("menu_icon")]
        public string MenuIcon;

        [XmlRpcMember("show_in_menu")]
        public bool ShowInMenu;

        [XmlRpcMember("taxonomies")]
        public XmlRpcStruct[] Taxonomies;

    }

}
