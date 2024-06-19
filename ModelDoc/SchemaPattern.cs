using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ModelDoc;

public class SchemaPattern
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
  public string? Pattern
  {
    get; set;
  }
}
