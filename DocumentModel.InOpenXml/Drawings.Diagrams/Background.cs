namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Background Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Background))]
public partial class Background : ModelElement<DXDD.Background>
{
  /// <summary>
  /// Fill.
  /// </summary>
  [OpenXmlElement(typeof(DXD.NoFill))]
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;
  /// <summary>
  /// Effect List.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectList))]
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

  private EffectList? _EffectList;
  /// <summary>
  /// Effect Dag.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectDag))]
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

  private EffectDag? _EffectDag;
}