namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface SchemaLibrary
{
  public Collection<DocumentModel.CustomXml.Schema>? Schemas { get ; set; }
  
}
