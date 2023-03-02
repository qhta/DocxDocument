namespace DocumentModel.CustomXml;

/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public record SchemaReferences
{
  public Collection<SchemaReference>? Items { get; set; }
}