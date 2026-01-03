namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
public interface Background: IModelElement
{
  public Fill? Fill { get; set; }
  public EffectList? EffectList { get; set; }
  public EffectDag? EffectDag { get; set; }
}