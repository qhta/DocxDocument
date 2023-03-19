namespace DocumentModel.CustomXml;

/// <summary>
///   Embedded Custom XML Schema Supplementary Data.
/// </summary>
public class SchemaLibrary: ModelElement
{
  public Collection<Schema>? Schemas { get; set; }
}