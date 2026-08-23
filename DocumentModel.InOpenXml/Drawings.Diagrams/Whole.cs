namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Whole E2O Formatting.
/// </summary>
[OpenXmlType(typeof(DXDD.Whole))]
[DataContract]
[XmlRoot("Whole", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Whole : ModelElement<DXDD.Whole>
{
  /// <summary>
  ///   Outline.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Whole.Outline))]
  public LineProperties? Outline
  {
    get => _Outline ??= GetProperty<LineProperties?>(GetUpdatableElement()?.Outline);
    set => UpdateField(ref _Outline, value, nameof(Outline));
  }
  private LineProperties? _Outline;

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