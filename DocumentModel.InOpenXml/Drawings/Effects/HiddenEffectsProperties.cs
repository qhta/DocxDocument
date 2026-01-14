namespace DocumentModel.Drawings;

/// <summary>
///   Represents hidden effects properties for a drawing element, including effect containers.
/// </summary>
public class HiddenEffectsProperties: ModelElement
{
  /// <summary>
  ///   List of effects applied to the element.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}