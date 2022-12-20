namespace DocumentModel;

/// <summary>
/// Defines the ClassificationExtension Class.
/// </summary>
public partial class ClassificationExtensionImpl: ModelElementImpl, ClassificationExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ClassificationExtensionImpl(): base() {}
  
  public ClassificationExtensionImpl(DocumentFormat.OpenXml.Office2021.MipLabelMetaData.ClassificationExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// uri, this property is only available in Office 2021 and later.
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
