//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BootstrapMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Post1 = new HashSet<Post>();
        }
    
        public int ID { get; set; }
        public string PostDetail { get; set; }
        public Nullable<int> MasterPostID { get; set; }
        public int TitleID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual ICollection<Post> Post1 { get; set; }
        public virtual Post Post2 { get; set; }
        public virtual Title Title { get; set; }
    }
}
