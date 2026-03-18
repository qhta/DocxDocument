namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   EffectReference in ChartsStyle extends EffectReference in Drawings with StyleColor.
/// </summary>
public class EffectReference : DocumentModel.Drawings.EffectReference
{
  public StyleColor? StyleColor { get; set; }
}