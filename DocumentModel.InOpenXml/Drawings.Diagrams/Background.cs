namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Background Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Background))]
[DataContract]
[XmlRoot("Background", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Background: ModelElement<DXDD.Background>
{
  /// <summary>
  /// Fill.
  /// </summary>
  [OpenXmlElement(typeof(DXD.NoFill))]
  public Fill? Fill
  {
    get => _Fill ??= GetElement<Fill, DXD.NoFill>(GetUpdatableElement());
    set => UpdateField(ref _Fill, value, nameof(Fill));
  }

  private Fill? _Fill;

  /// <summary>
  /// Effect List.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectList))]
  public EffectList? EffectList
  {
    get => _EffectList ??= GetElement<EffectList, DXD.EffectList>(GetUpdatableElement());
    set => UpdateField(ref _EffectList, value, nameof(EffectList));
  }

  private EffectList? _EffectList;

  /// <summary>
  /// Effect Dag.
  /// </summary>
  [OpenXmlElement(typeof(DXD.EffectDag))]
  public EffectDag? EffectDag
  {
    get => _EffectDag ??= GetElement<EffectDag, DXD.EffectDag>(GetUpdatableElement());
    set => UpdateField(ref _EffectDag, value, nameof(EffectDag));
  }

  private EffectDag? _EffectDag;
}