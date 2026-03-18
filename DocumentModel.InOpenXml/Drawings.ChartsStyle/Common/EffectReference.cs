namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   EffectReference in ChartsStyle extends EffectReference in Drawings with StyleColor.
/// </summary>
public class EffectReference : DocumentModel.Drawings.EffectReference
{
  /// <summary>
  /// Refers to color configuration for the effect, allowing for detailed styling of chart effects such as shadows, glows, and reflections.
  /// </summary>
  public StyleColor? StyleColor { get; set; }
}