using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace ModelDoc;

public abstract class SchemaType
{

  [Key] public int Id { get; set; }

  public int SchemaFileId { get; set; }

  [MaxLength(255)]
  public string? TypeName { get; set; }

  public int? BaseNamespaceId { get; set; }

  [MaxLength(255)]
  public string? BaseTypeName { get; set; }

  public SchemaFile? SchemaFile { get; set; }

}
