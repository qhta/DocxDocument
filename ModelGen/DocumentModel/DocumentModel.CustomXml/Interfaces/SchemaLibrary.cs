namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface SchemaLibrary
{
  public Collection<Schema>? Schemas { get ; set; }
  
}
