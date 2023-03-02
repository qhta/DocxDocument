namespace DocumentModel.CustomXml;

/// <summary>
///   Embedded Custom XML Schema Supplementary Data.
/// </summary>
public record SchemaLibrary
{
  public Collection<Schema>? Schemas { get; set; }
}