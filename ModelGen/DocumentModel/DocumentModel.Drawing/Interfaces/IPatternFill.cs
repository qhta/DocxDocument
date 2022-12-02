namespace DocumentModel.Drawing;

/// <summary>
/// Pattern Fill.
/// </summary>
public interface IPatternFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public PresetPatternKind? Preset { get ; set; }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public IForegroundColor? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public IBackgroundColor? BackgroundColor { get ; set; }
  
}
