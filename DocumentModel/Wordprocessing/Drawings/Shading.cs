using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the IShading Class.
/// </summary>
public class IShading: ModelElement
{
  /// <summary>
  ///   IShading Pattern
  /// </summary>
  public ShadingPatternKind? Pattern { get; set; }

  /// <summary>
  /// Color of the pattern foreground.
  /// </summary>
  public DM.Color? ForegroundColor {get; set; }

  /// <summary>
  /// Color of the pattern background.
  /// </summary>
  public DM.Color? BackgroundColor {get; set; }

}
