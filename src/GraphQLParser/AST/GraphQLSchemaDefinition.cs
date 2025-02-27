﻿using System.Collections.Generic;

namespace GraphQLParser.AST
{
    public class GraphQLSchemaDefinition : ASTNode, IHasDirectivesNode
    {
        public IEnumerable<GraphQLDirective> Directives { get; set; }

        public override ASTNodeKind Kind => ASTNodeKind.SchemaDefinition;

        public IEnumerable<GraphQLOperationTypeDefinition> OperationTypes { get; set; }
    }
}