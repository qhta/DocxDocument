namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
public class Background: ModelElement
{
  public Fill? Fill { get; set; }
  public EffectList? EffectList { get; set; }
  public EffectDag? EffectDag { get; set; }
}