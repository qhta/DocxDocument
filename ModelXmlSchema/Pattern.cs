using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;

public class Pattern
{

  [Key]
  public int Id
  {
    get; set;
  }

  public int SimpleTypeId
  {
    get; set;
  }


  [MaxLength(255)]
  public string? Value
  {
    get; set;
  }
}
