namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Background))]
/// <summary>
/// Represents the Background.
/// </summary>
public class Background: ModelElement<DXDD.Background>
{
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill { get; set; }
  /// <summary>
  /// Effect List.
  /// </summary>
  public EffectList? EffectList { get; set; }
  /// <summary>
  /// Effect Dag.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
}

