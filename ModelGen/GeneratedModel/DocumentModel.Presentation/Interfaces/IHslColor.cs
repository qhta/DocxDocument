namespace DocumentModel.Presentation;

/// <summary>
/// HSL.
/// </summary>
public interface IHslColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public int? Hue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public int? Saturation { get ; set; }
  
  /// <summary>
  /// Lightness
  /// </summary>
  public int? Lightness { get ; set; }
  
}
