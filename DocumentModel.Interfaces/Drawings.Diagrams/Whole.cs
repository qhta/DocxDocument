namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Whole E2O Formatting.
/// </summary>
public interface Whole
{
  /// <summary>
  ///   Outline.
  /// </summary>
  public LineProperties? Outline { get; set; }
  public EffectList? EffectList { get; set; }
  public EffectDag? EffectDag { get; set; }
}