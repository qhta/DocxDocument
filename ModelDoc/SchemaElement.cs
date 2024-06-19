using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaElement: SchemaParticle
{

  public int? RefNamespaceId { get; set; }

  [MaxLength(255)]
  public string? Name { get; set; }

  public int? TypeNamespaceId { get; set; }

  [MaxLength(255)]
  public string? TypeName { get; set; }

}
