using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ModelXmlSchema;
public class SchemaNamespacePrefix
{
  public SchemaNamespacePrefix() { }

  public int SchemaNamespaceId { get; set; }
  
  [MaxLength(10)]
  public string? Prefix { get; set; }

  public int Count { get; set; }
}
