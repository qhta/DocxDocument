namespace DocumentModel.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public partial class SchemaReferenceImpl: ModelElementImpl, SchemaReference
{
  public DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SchemaReferenceImpl(): base() {}
  
  public SchemaReferenceImpl(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
}
