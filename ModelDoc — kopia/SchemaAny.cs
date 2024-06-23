using System.ComponentModel.DataAnnotations;

namespace ModelDoc;

/// <summary>
/// Represents a group of elements that can appear in any order.
/// </summary>
public class SchemaAny: SchemaParticle
{
  [MaxLength(255)]
  public string? Namespace { get; set; }

  public ContentProcessing? ProcessContents { get; set; }

}
