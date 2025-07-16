using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_E_Ticaret.Domain.Entities;

public class Image:BaseEntity
{
    public string Image_Url { get; set; }
    public Guid ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
