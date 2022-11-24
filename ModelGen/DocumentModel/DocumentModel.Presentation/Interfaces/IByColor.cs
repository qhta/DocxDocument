namespace DocumentModel.Presentation;

/// <summary>
/// By.
/// </summary>
public interface IByColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RGB.
  /// </summary>
  public IRgbColor? RgbColor { get ; set; }
  
  /// <summary>
  /// HSL.
  /// </summary>
  public IHslColor? HslColor { get ; set; }
  
}
