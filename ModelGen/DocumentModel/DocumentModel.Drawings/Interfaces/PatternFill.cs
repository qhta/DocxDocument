namespace DocumentModel.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public partial interface PatternFill
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public DocumentModel.Drawings.PresetPatternKind? Preset { get; set; }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public DocumentModel.Drawings.ForegroundColor? ForegroundColor { get; set; }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public DocumentModel.Drawings.BackgroundColor? BackgroundColor { get; set; }
  
}
