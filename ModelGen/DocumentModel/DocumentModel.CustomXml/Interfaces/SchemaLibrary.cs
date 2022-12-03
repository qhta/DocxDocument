namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface SchemaLibrary // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<Schema>? Schemas { get ; set; }
  
}
