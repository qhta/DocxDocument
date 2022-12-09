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
    get => (Int32?)OpenXmlElement?.Brightness?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Brightness = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public Int32? Contrast
  {
    get => (Int32?)OpenXmlElement?.Contrast?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Contrast = (System.Int32?)value;
    }
  }
  
}
