namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SVGBlip Class.
/// </summary>
public class SVGBlipImpl: ModelElementImpl, SVGBlip
{
  public DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.SVG.SVGBlip?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed
  {
    get => (String?)OpenXmlElement?.Embed?.Value;
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
    get => (String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
}
