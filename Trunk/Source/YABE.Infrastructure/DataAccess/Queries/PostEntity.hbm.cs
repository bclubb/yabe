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
        /// Query helper for member Where.PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public static Root_Query_PostEntity PostEntity {
            get {
                return new Root_Query_PostEntity();
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Query_PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class Query_PostEntity<T1> : QueryBuilder<T1>
         {
            
            /// <summary>
            /// Query helper for member Query_PostEntity..ctor
            /// </summary>
            public Query_PostEntity() : 
                    this(null, "this", null) {
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity..ctor
            /// </summary>
            public Query_PostEntity(QueryBuilder<T1> parent, string name, string associationPath) : 
                    base(parent, name, associationPath) {
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity..ctor
            /// </summary>
            public Query_PostEntity(QueryBuilder<T1> parent, string name, string associationPath, bool backTrackAssociationOnEquality) : 
                    base(parent, name, associationPath, backTrackAssociationOnEquality) {
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> DateCreated {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "DateCreated", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> Title {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "Title", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> Text {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "Text", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> DatePublished {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "DatePublished", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual PropertyQueryBuilder<T1> Slug {
                get {
                    string temp = associationPath;
                    PropertyQueryBuilder<T1> child = new PropertyQueryBuilder<T1>(null, "Slug", temp);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
            
            /// <summary>
            /// Query helper for member Query_PostEntity.
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
            /// Query helper for member Query_PostEntity.
            /// </summary>
            public virtual Query_BlogEntity<T1> Blog {
                get {
                    string temp = associationPath;
                    temp = ((temp + ".") 
                                + "Blog");
                    Query_BlogEntity<T1> child = new Query_BlogEntity<T1>(null, "Blog", temp, true);
                    child.ShouldSkipJoinOnIdEquality = this.ShouldSkipJoinOnIdEquality;
                    return child;
                }
            }
        }
        
        /// <summary>
        /// Query helper for member Where.Root_Query_PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class Root_Query_PostEntity : Query_PostEntity<YABE.Domain.Model.PostEntity> {
        }
    }
    
    public partial class OrderBy {
        
        /// <summary>
        /// Query helper for member OrderBy.PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class PostEntity {
            
            /// <summary>
            /// Query helper for member PostEntity.DateCreated
            /// </summary>
            public static OrderByClause DateCreated {
                get {
                    return new OrderByClause("DateCreated");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Title
            /// </summary>
            public static OrderByClause Title {
                get {
                    return new OrderByClause("Title");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Text
            /// </summary>
            public static OrderByClause Text {
                get {
                    return new OrderByClause("Text");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.DatePublished
            /// </summary>
            public static OrderByClause DatePublished {
                get {
                    return new OrderByClause("DatePublished");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Slug
            /// </summary>
            public static OrderByClause Slug {
                get {
                    return new OrderByClause("Slug");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Id
            /// </summary>
            public static OrderByClause Id {
                get {
                    return new OrderByClause("Id");
                }
            }
        }
    }
    
    public partial class ProjectBy {
        
        /// <summary>
        /// Query helper for member ProjectBy.PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class PostEntity {
            
            /// <summary>
            /// Query helper for member PostEntity.DateCreated
            /// </summary>
            public static PropertyProjectionBuilder DateCreated {
                get {
                    return new PropertyProjectionBuilder("DateCreated");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Title
            /// </summary>
            public static PropertyProjectionBuilder Title {
                get {
                    return new PropertyProjectionBuilder("Title");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Text
            /// </summary>
            public static PropertyProjectionBuilder Text {
                get {
                    return new PropertyProjectionBuilder("Text");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.DatePublished
            /// </summary>
            public static PropertyProjectionBuilder DatePublished {
                get {
                    return new PropertyProjectionBuilder("DatePublished");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Slug
            /// </summary>
            public static PropertyProjectionBuilder Slug {
                get {
                    return new PropertyProjectionBuilder("Slug");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Id
            /// </summary>
            public static PropertyProjectionBuilder Id {
                get {
                    return new PropertyProjectionBuilder("Id");
                }
            }
        }
    }
    
    public partial class GroupBy {
        
        /// <summary>
        /// Query helper for member GroupBy.PostEntity
        /// </summary>
        [System.CLSCompliantAttribute(false)]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("NHibernate.Query.Generator", "0.0.0.0")]
        public partial class PostEntity {
            
            /// <summary>
            /// Query helper for member PostEntity.DateCreated
            /// </summary>
            public static NHibernate.Criterion.IProjection DateCreated {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("DateCreated");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Title
            /// </summary>
            public static NHibernate.Criterion.IProjection Title {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Title");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Text
            /// </summary>
            public static NHibernate.Criterion.IProjection Text {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Text");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.DatePublished
            /// </summary>
            public static NHibernate.Criterion.IProjection DatePublished {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("DatePublished");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Slug
            /// </summary>
            public static NHibernate.Criterion.IProjection Slug {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Slug");
                }
            }
            
            /// <summary>
            /// Query helper for member PostEntity.Id
            /// </summary>
            public static NHibernate.Criterion.IProjection Id {
                get {
                    return NHibernate.Criterion.Projections.GroupProperty("Id");
                }
            }
        }
    }
}