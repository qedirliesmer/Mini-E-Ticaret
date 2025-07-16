using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_E_Ticaret.Domain.Entities;

public class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }

    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    public ICollection<Favorite> Favorites { get; set; } = new HashSet<Favorite>();
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? ExpiryDate { get; set; }

}
