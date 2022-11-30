namespace DocumentModel.Drawing;

/// <summary>
/// Pattern Fill.
/// </summary>
public interface IPatternFill // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public DocumentModel.Drawing.PresetPatternKind? Preset { get ; set; }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public DocumentModel.Drawing.IForegroundColor? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public DocumentModel.Drawing.IBackgroundColor? BackgroundColor { get ; set; }
  
}
