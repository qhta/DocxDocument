namespace DocumentModel.Math;

/// <summary>
///   This element specifies the Lower-Limit object, consisting of text on the baseline 
///   and reduced-size text immediately below it. Examples of limLow include lim and max.
/// </summary>
[OpenXmlType(typeof(DXM.LimitLower))]
[DataContract]
[XmlRoot("LimitLower", Namespace = "DocumentModel.Math")]
public partial class LimitLower: ModelElement<DXM.LimitLower>, ICommonMathContent
{
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.LimitLower.LimitLowerProperties))]
  public LimitLowerProperties? LimitLowerProperties
  {
    get => _LimitLowerProperties ??= GetProperty<LimitLowerProperties?>(GetUpdatableElement()?.LimitLowerProperties);
    set => UpdateField(ref _LimitLowerProperties, value, nameof(LimitLowerProperties));
  }

  private LimitLowerProperties? _LimitLowerProperties;

  /// <summary>
  ///   Specifies the argument of limit-lower function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.LimitLower.Base))]
  public Base? Base
  {
    get => _Base ??= GetProperty<Base?>(GetUpdatableElement()?.Base);
    set => UpdateField(ref _Base, value, nameof(Base));
  }

  private Base? _Base;

  /// <summary>
  ///   Limit (lower.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.LimitLower.Limit))]
  public Limit? Limit
  {
    get => _Limit ??= GetProperty<Limit?>(GetUpdatableElement()?.Limit);
    set => UpdateField(ref _Limit, value, nameof(Limit));
  }

  private Limit? _Limit;
}