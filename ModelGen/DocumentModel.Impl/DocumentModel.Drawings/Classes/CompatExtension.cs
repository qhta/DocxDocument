namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public partial class CompatExtensionImpl: ModelElementImpl, CompatExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CompatExtensionImpl(): base() {}
  
  public CompatExtensionImpl(DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId
  {
    get => (System.String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
}
