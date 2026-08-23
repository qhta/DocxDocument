namespace DocumentModel.Math;

/// <summary>
///   Subscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.Subscript))]
[DataContract]
[XmlRoot("Subscript", Namespace = "DocumentModel.Math")]
public partial class Subscript: ModelElement<DXM.Subscript>, ICommonMathContent
{
  /// <summary>
  ///   Subscript Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Subscript.SubscriptProperties))]
  public SubscriptProperties? SubscriptProperties
  {
    get => _SubscriptProperties ??= GetProperty<SubscriptProperties?>(GetUpdatableElement()?.SubscriptProperties);
    set => UpdateField(ref _SubscriptProperties, value, nameof(SubscriptProperties));
  }

  private SubscriptProperties? _SubscriptProperties;

  /// <summary>
  ///   Specifies the argument of subscript function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Subscript.Base))]
  public Base? Base
  {
    get => _Base ??= GetProperty<Base?>(GetUpdatableElement()?.Base);
    set => UpdateField(ref _Base, value, nameof(Base));
  }

  private Base? _Base;

  /// <summary>
  ///   Subscript (Subscript function).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Subscript.SubArgument))]
  public SubArgument? SubArgument
  {
    get => _SubArgument ??= GetProperty<SubArgument?>(GetUpdatableElement()?.SubArgument);
    set => UpdateField(ref _SubArgument, value, nameof(SubArgument));
  }

  private SubArgument? _SubArgument;
}