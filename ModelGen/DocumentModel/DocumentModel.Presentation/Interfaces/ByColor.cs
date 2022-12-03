namespace DocumentModel.Presentation;

/// <summary>
/// By.
/// </summary>
public interface ByColor // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// RGB.
  /// </summary>
  public RgbColor? RgbColor { get ; set; }
  
  /// <summary>
  /// HSL.
  /// </summary>
  public HslColor? HslColor { get ; set; }
  
}
