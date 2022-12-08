namespace DocumentModel.Drawings;

/// <summary>
/// Luminance.
/// </summary>
public class LuminanceEffectImpl: ModelElementImpl, LuminanceEffect
{
  public DocumentFormat.OpenXml.Drawing.LuminanceEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LuminanceEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Brightness
  /// </summary>
  public Int32? Brightness
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public Int32? Contrast
  {
    get;
    set;
  }
  
}
