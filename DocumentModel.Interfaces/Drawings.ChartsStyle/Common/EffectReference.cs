namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   EffectReference in ChartsStyle extends EffectReference in Drawings with StyleColor.
/// </summary>
public interface EffectReference: DocumentModel.Drawings.EffectReference
{
  public StyleColor? StyleColor { get; set; }
}