using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaGroupRef: SchemaParticle
{

  public int? RefNamespaceId { get; set; }

  [MaxLength(255)]
  public string? Name { get; set; }

}
