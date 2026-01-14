namespace DocumentModel.Drawings;

/// <summary>
///   Represents a pattern fill, including preset pattern type and foreground/background colors.
/// </summary>
public class PatternFill: ModelElement
{
  /// <summary>
  ///   Preset pattern type used for the fill.
  /// </summary>
  public PresetPatternKind? Preset { get; set; }

  /// <summary>
  ///   Foreground color of the pattern.
  /// </summary>
  public ForegroundColor? ForegroundColor { get; set; }

  /// <summary>
  ///   Background color of the pattern.
  /// </summary>
  public BackgroundColor? BackgroundColor { get; set; }
}