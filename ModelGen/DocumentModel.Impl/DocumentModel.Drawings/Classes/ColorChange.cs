namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public class ColorChangeImpl: ModelElementImpl, ColorChange
{
  public DocumentFormat.OpenXml.Drawing.ColorChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha
  {
    get;
    set;
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public ColorTo? ColorTo
  {
    get;
    set;
  }
  
}
