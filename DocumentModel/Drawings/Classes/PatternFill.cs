namespace DocumentModel.Drawings;

/// <summary>
///   Pattern Fill.
/// </summary>
public class PatternFill
{
  /// <summary>
  ///   Preset Pattern
  /// </summary>
  public PresetPatternKind? Preset { get; set; }

  /// <summary>
  ///   Foreground color.
  /// </summary>
  public ForegroundColor? ForegroundColor { get; set; }

  /// <summary>
  ///   Background color.
  /// </summary>
  public BackgroundColor? BackgroundColor { get; set; }
}