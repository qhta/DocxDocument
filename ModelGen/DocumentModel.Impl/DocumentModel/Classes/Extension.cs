namespace DocumentModel;

/// <summary>
/// Defines the Extension Class.
/// </summary>
public partial class ExtensionImpl: ModelElementImpl, Extension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtensionImpl(): base() {}
  
  public ExtensionImpl(DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension openXmlElement): base(openXmlElement)
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
