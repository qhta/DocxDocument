namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Background))]
public class Background: ModelElement<DXDD.Background>
{
  public Fill? Fill { get; set; }
  public EffectList? EffectList { get; set; }
  public EffectDag? EffectDag { get; set; }
}