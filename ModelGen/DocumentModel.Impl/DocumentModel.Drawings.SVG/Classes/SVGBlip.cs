namespace DocumentModel.Drawings.SVG;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public partial class SVGBlipImpl: ModelElementImpl, SVGBlip
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SVGBlipImpl(): base() {}
  
  public SVGBlipImpl(DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed
  {
    get => (System.String?)OpenXmlElement?.Embed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Embed = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link
  {
    get => (System.String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
}
