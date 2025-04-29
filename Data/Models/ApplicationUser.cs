using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data.Models;

[Index("Email", Name = "UQ__Users__A9D10534F8C2D09D", IsUnique = true)]
public partial class ApplicationUser : IdentityUser<long>
{
    

    [StringLength(150)]
    public string FullName { get; set; } = null!;
    public bool? IsActive { get; set; }

    //[Column(TypeName = "datetime")]
    //public DateTime? CreatedAt { get; set; }

    //[Column(TypeName = "datetime")]
    //public DateTime? UpdatedAt { get; set; }

    //[Column(TypeName = "datetime")]
    //public DateTime? LastLoginDate { get; set; }

    //public long CreatedBy { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    [InverseProperty("User")]
    public virtual Cart? Cart { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("User")]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
