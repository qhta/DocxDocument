namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public class SchemaLibraryImpl: ModelElementImpl, SchemaLibrary
{
  public DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Schema>? Schemas
  {
    get;
    set;
  }
  
}
