using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

public class SchemaAny: SchemaParticle
{
  [MaxLength(255)]
  public string? Namespace { get; set; }

  public ContentProcessing? ProcessContents { get; set; }

}
