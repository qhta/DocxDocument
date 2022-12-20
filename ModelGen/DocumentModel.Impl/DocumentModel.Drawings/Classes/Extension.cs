namespace DocumentModel.Drawings;

/// <summary>
/// Extension.
/// </summary>
public partial class ExtensionImpl: ModelElementImpl, Extension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Extension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtensionImpl(): base() {}
  
  public ExtensionImpl(DocumentFormat.OpenXml.Drawing.Extension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
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
