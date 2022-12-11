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
  
  public SchemaLibraryImpl(): base() {}
  
  public SchemaLibraryImpl(DocumentFormat.OpenXml.CustomXmlSchemaReferences.SchemaLibrary openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<Schema>? Schemas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
