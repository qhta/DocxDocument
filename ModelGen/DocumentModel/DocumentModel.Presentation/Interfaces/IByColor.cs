namespace DocumentModel.Presentation;

/// <summary>
/// By.
/// </summary>
public interface IByColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// RGB.
  /// </summary>
  public DocumentModel.Presentation.IRgbColor? RgbColor { get ; set; }
  
  /// <summary>
  /// HSL.
  /// </summary>
  public DocumentModel.Presentation.IHslColor? HslColor { get ; set; }
  
}
