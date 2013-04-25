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
    public static class ExtensionMethods
    {
        public static string ToRPC(this PostStatus e)
        {
            switch (e)
            {
                case PostStatus.Any:
                    return "any";

                case PostStatus.AutoDraft:
                    return "pending";

                case PostStatus.Draft:
                    return "draft";

                case PostStatus.Future:
                    return "future";

                case PostStatus.Inherit:
                    return "inherit";

                case PostStatus.Pending:
                    return "pending";

                case PostStatus.Private:
                    return "private";

                case PostStatus.Published:
                    return "publish";

                case PostStatus.Trash:
                    return "trash";
            }

            throw new NotImplementedException();
        }

        public static string ToRPC(this Ordering e)
        {
            switch (e)
            {
                case Ordering.Ascending:
                    return "ascending";

                case Ordering.Descending:
                    return "descending";
            }

            throw new NotImplementedException();
        }

        public static string ToRPC(this PostOrderBy e)
        {
            switch (e)
            {
                case PostOrderBy.Author:
                    return "author";

                case PostOrderBy.CommentCount:
                    throw new NotImplementedException();
                    //return "comment_count";

                case PostOrderBy.Date:
                    return "date";

                case PostOrderBy.ID:
                    return "id";

                case PostOrderBy.MenuOrder:
                    throw new NotImplementedException();
                    //return "menu_order";

                case PostOrderBy.Modified:
                    return "modified";

                case PostOrderBy.Name:
                    return "name";

                case PostOrderBy.None:
                    return "none";

                case PostOrderBy.Parent:
                    return "parent";

                case PostOrderBy.Random:
                    return "random";

                case PostOrderBy.Title:
                    return "title";

            }

            throw new NotImplementedException();
        }

    }
}
