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
    public struct Term
    {
        public int ID;

        public string Name;

        public string Slug;

        public string TermGroup;

        public int TermTaxonomyID;

        public string Taxonomy;

        public string Description;

        public string Parent;

        public int Count;
    }
}
