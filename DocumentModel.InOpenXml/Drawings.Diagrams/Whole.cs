namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Whole E2O Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Whole))]
/// <summary>
/// Represents the Whole.
/// </summary>
public class Whole: ModelElement<DXDD.Whole>
{
  /// <summary>
  ///   Outline.
  /// </summary>
  public LineProperties? Outline { get; set; }
  /// <summary>
  /// Effect List.
  /// </summary>
  public EffectList? EffectList { get; set; }
  /// <summary>
  /// Effect Dag.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}

