namespace DocumentModel.Presentation;

/// <summary>
/// HSL.
/// </summary>
public interface IHslColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public Int32? Saturation { get ; set; }
  
  /// <summary>
  /// Lightness
  /// </summary>
  public Int32? Lightness { get ; set; }
  
}
