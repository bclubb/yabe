//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 11/21/2008 10:43:01 AM
// This source code was auto-generated by NHQG (), Version 0.0.0.0.
// 
namespace Query {
    
    
    public partial class Where {
        
        /// <summary>
        /// Query helper for member Where.BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public static Root_Query_BlogEntity BlogEntity {
            get {
                return new Root_Query_BlogEntity();
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Query_BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class Query_BlogEntity<T1> : QueryBuilder<T1>
         {
            
            /// <summary>
            /// Query helper for member Query_BlogEntity..ctor
            /// </summary>
            public Query_BlogEntity() : 
                    this(null, "this", null) {
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity..ctor
            /// </summary>
            public Query_BlogEntity(QueryBuilder<T1> parent, string name, string associationPath) : 
                    base(parent, name, associationPath) {
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity..ctor
            /// </summary>
            public Query_BlogEntity(QueryBuilder<T1> parent, string name, string associationPath, bool backTrackAssociationOnEquality) : 
                    base(parent, name, associationPath, backTrackAssociationOnEquality) {
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> Host {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "Host", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity.
            /// </summary>
            public virtual IdQueryBuilder<T1> Id {
                get {
                    string temp = associationPath;
                    IdQueryBuilder<T1> child = new IdQueryBuilder<T1>(null, "Id", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity.Options
            /// </summary>
            public virtual Query_Options<T1> Options {
                get {
                    return new Query_Options<T1>(this, "Options", this.associationPath);
                }
            }
            
            /// <summary>
            /// Query helper for member Query_BlogEntity.Query_Options
            /// </summary>
            [System.CLSCompliantAttribute(false)]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
            public partial class Query_Options<T2> : QueryBuilder<T2>
             {
                
                /// <summary>
                /// Query helper for member Query_Options..ctor
                /// </summary>
                public Query_Options() : 
                        this(null, "this", null) {
                }
                
                /// <summary>
                /// Query helper for member Query_Options..ctor
                /// </summary>
                public Query_Options(QueryBuilder<T2> parent, string name, string associationPath) : 
                        base(parent, name, associationPath) {
                }
                
                /// <summary>
                /// Query helper for member Query_Options..ctor
                /// </summary>
                public Query_Options(QueryBuilder<T2> parent, string name, string associationPath, bool backTrackAssociationOnEquality) : 
                        base(parent, name, associationPath, backTrackAssociationOnEquality) {
                }
                
                /// <summary>
                /// Query helper for member Query_Options.
                /// </summary>
                public virtual PropertyQueryBuilder<T2> NumberOfPostsToShowOnHomePage {
                    get {
                        string temp = associationPath;
                        PropertyQueryBuilder<T2> child = new PropertyQueryBuilder<T2>(null, "Options.NumberOfPostsToShowOnHomePage", temp);
                        child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                        return child;
                    }
                }
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Root_Query_BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class Root_Query_BlogEntity : Query_BlogEntity<YABE.Domain.Model.BlogEntity> {
        }
    }
    
    public partial class OrderBy {
        
        /// <summary>
        /// Query helper for member OrderBy.BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class BlogEntity {
            
            /// <summary>
            /// Query helper for member BlogEntity.Host
            /// </summary>
            public static OrderByClause Host {
                get {
                    return new OrderByClause("Host");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Id
            /// </summary>
            public static OrderByClause Id {
                get {
                    return new OrderByClause("Id");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Options
            /// </summary>
            [System.CLSCompliantAttribute(false)]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
            public partial class Options {
                
                /// <summary>
                /// Query helper for member Options.NumberOfPostsToShowOnHomePage
                /// </summary>
                public static OrderByClause NumberOfPostsToShowOnHomePage {
                    get {
                        return new OrderByClause("Options.NumberOfPostsToShowOnHomePage");
                    }
                }
            }
        }
    }
    
    public partial class ProjectBy {
        
        /// <summary>
        /// Query helper for member ProjectBy.BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class BlogEntity {
            
            /// <summary>
            /// Query helper for member BlogEntity.Host
            /// </summary>
            public static PropertyProjectionBuilder Host {
                get {
                    return new PropertyProjectionBuilder("Host");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Id
            /// </summary>
            public static PropertyProjectionBuilder Id {
                get {
                    return new PropertyProjectionBuilder("Id");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Options
            /// </summary>
            [System.CLSCompliantAttribute(false)]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
            public partial class Options {
                
                /// <summary>
                /// Query helper for member Options.NumberOfPostsToShowOnHomePage
                /// </summary>
                public static PropertyProjectionBuilder NumberOfPostsToShowOnHomePage {
                    get {
                        return new PropertyProjectionBuilder("Options.NumberOfPostsToShowOnHomePage");
                    }
                }
            }
        }
    }
    
    public partial class GroupBy {
        
        /// <summary>
        /// Query helper for member GroupBy.BlogEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class BlogEntity {
            
            /// <summary>
            /// Query helper for member BlogEntity.Host
            /// </summary>
            public static NHibernate.Criterion.IProjection Host {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Host");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Id
            /// </summary>
            public static NHibernate.Criterion.IProjection Id {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Id");
                }
            }
            
            /// <summary>
            /// Query helper for member BlogEntity.Options
            /// </summary>
            [System.CLSCompliantAttribute(false)]
            [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
            public partial class Options {
                
                /// <summary>
                /// Query helper for member Options.NumberOfPostsToShowOnHomePage
                /// </summary>
                public static NHibernate.Criterion.IProjection NumberOfPostsToShowOnHomePage {
                    get {
                        return NHibernate.Criterion.Projections.GroupProperty("Options.NumberOfPostsToShowOnHomePage");
                    }
                }
            }
        }
    }
}