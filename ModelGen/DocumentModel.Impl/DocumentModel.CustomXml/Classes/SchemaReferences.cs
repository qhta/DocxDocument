namespace DocumentModel.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public class SchemaReferencesImpl: ModelElementImpl, SchemaReferences
{
  public DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SchemaReferencesImpl(): base() {}
  
  public SchemaReferencesImpl(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<SchemaReference>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
