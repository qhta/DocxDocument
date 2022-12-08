namespace DocumentModel.Drawings;

/// <summary>
/// Hue Saturation Luminance Effect.
/// </summary>
public class HslImpl: ModelElementImpl, Hsl
{
  public DocumentFormat.OpenXml.Drawing.Hsl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Hsl?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? Saturation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Luminance
  /// </summary>
  public Int32? Luminance
  {
    get;
    set;
  }
  
}
