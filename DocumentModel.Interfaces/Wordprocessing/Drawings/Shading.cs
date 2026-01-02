using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Shading Class.
/// </summary>
public class Shading: ModelElement
{
  /// <summary>
  ///   Shading Pattern
  /// </summary>
  public ShadingPatternKind? Pattern { get; set; }
  /// <summary>
  /// Color of the pattern foreground.
  /// </summary>
  public DM.IColor? ForegroundColor {get; set; }
  /// <summary>
  /// Color of the pattern background.
  /// </summary>
  public DM.IColor? BackgroundColor {get; set; }
}