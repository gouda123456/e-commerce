using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.Data.Models;

[Index("Email", Name = "UQ__Users__A9D10534F8C2D09D", IsUnique = true)]
public partial class User
{
    [Key]
    public long Id { get; set; }

    [StringLength(150)]
    public string FullName { get; set; } = null!;

    [StringLength(100)]
    public string UserName { get; set; } = null!;

    [StringLength(150)]
    public string Email { get; set; } = null!;

    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    public string PasswordHash { get; set; } = null!;

    [StringLength(50)]
    public string? Role { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsEmailConfirmed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastLoginDate { get; set; }

    public string? ResetPasswordToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ResetPasswordTokenExpire { get; set; }

    public bool? TwoFactorEnabled { get; set; }

    public long CreatedBy { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    [InverseProperty("User")]
    public virtual Cart? Cart { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("User")]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
