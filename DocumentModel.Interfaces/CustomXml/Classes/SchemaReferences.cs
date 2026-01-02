namespace DocumentModel.CustomXml;

/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public class SchemaReferences: ModelElement
{
  public Collection<SchemaReference>? Items { get; set; }
}