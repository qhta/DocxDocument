namespace DocumentModel.Presentation;

/// <summary>
/// HSL.
/// </summary>
public interface IHslColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public System.Int32? Hue { get ; set; }
  
  /// <summary>
  /// Saturation
  /// </summary>
  public System.Int32? Saturation { get ; set; }
  
  /// <summary>
  /// Lightness
  /// </summary>
  public System.Int32? Lightness { get ; set; }
  
}
