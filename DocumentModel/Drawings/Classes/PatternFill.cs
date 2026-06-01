namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Pattern Fill.
/// </summary>
public class PatternFill: ModelElement
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
