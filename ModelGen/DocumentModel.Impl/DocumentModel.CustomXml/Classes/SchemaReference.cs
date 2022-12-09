namespace DocumentModel.CustomXml;

/// <summary>
/// Associated XML Schema.
/// </summary>
public class SchemaReferenceImpl: ModelElementImpl, SchemaReference
{
  public DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri
  {
    get => (String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
}
