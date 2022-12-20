namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Extension.
/// </summary>
public partial class ExtensionImpl: ModelElementImpl, Extension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Extension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Extension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ExtensionImpl(): base() {}
  
  public ExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.Extension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Uniform Resource Identifier
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
