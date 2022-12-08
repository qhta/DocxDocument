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
    get;
    set;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link
  {
    get;
    set;
  }
  
}
