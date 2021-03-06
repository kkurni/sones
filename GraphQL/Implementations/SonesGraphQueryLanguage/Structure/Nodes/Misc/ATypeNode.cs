/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using Irony.Ast;
using Irony.Parsing;
using sones.GraphQL.GQL.Structure.Nodes.Expressions;

namespace sones.GraphQL.Structure.Nodes.Misc
{
    /// <summary>
    /// This node is requested in case of a type statement.
    /// </summary>
    public sealed class ATypeNode : AStructureNode, IAstNodeInit
    {
        #region Properties

        public TypeReferenceDefinition ReferenceAndType { get; private set; }

        #endregion

        #region constructor

        public ATypeNode()
        {
        }

        #endregion

        #region IAstNodeInit Members

        public void Init(ParsingContext context, ParseTreeNode parseNode)
        {
            var dbTypeName = parseNode.ChildNodes[0].Token.ValueString;

            if (parseNode.ChildNodes.Count == 2)
            {
                ReferenceAndType = new TypeReferenceDefinition(dbTypeName, parseNode.ChildNodes[1].Token.ValueString);
            }
            else
            {
                ReferenceAndType = new TypeReferenceDefinition(dbTypeName, dbTypeName);
            }
        }

        #endregion

        #region Equals Overrides

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            ATypeNode p = obj as ATypeNode;
            if ((System.Object)p == null)
            {
                return false;
            }

            return Equals(p);
        }

        public bool Equals(ATypeNode p)
        {
            // If parameter is null return false:
            if ((object)p == null)
            {
                return false;
            }

            return (this.ReferenceAndType.Reference == p.ReferenceAndType.Reference) && (this.ReferenceAndType.TypeName == p.ReferenceAndType.TypeName);

        }

        public static bool operator ==(ATypeNode a, ATypeNode b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.Equals(b);
        }

        public static bool operator !=(ATypeNode a, ATypeNode b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return this.ReferenceAndType.Reference.GetHashCode() ^ this.ReferenceAndType.TypeName.GetHashCode();
        }

        #endregion

        #region Override ToString()

        public override string ToString()
        {
            return String.Concat(ReferenceAndType.Reference, ".", ReferenceAndType.TypeName);
        }

        #endregion
    }
}
