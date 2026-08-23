namespace DocumentModel.Math;

/// <summary>
///   Sub-Superscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.SubSuperscript))]
[DataContract]
[XmlRoot("SubSuperscript", Namespace = "DocumentModel.Math")]
public partial class SubSuperscript: ModelElement<DXM.SubSuperscript>, ICommonMathContent
{
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.SubSuperscript.SubSuperscriptProperties))]
  public SubSuperscriptProperties? SubSuperscriptProperties
  {
    get => _SubSuperscriptProperties ??=
      GetProperty<SubSuperscriptProperties?>(GetUpdatableElement()?.SubSuperscriptProperties);
    set => UpdateField(ref _SubSuperscriptProperties, value, nameof(SubSuperscriptProperties));
  }

  private SubSuperscriptProperties? _SubSuperscriptProperties;

  /// <summary>
  ///   Specifies the argument of sub-superscript function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.SubSuperscript.Base))]
  public Base? Base
  {
    get => _Base ??= GetProperty<Base?>(GetUpdatableElement()?.Base);
    set => UpdateField(ref _Base, value, nameof(Base));
  }

  private Base? _Base;

  /// <summary>
  ///   Subscript (Sub-Superscript).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.SubSuperscript.SubArgument))]
  public SubArgument? SubArgument
  {
    get => _SubArgument ??= GetProperty<SubArgument?>(GetUpdatableElement()?.SubArgument);
    set => UpdateField(ref _SubArgument, value, nameof(SubArgument));
  }

  private SubArgument? _SubArgument;

  /// <summary>
  ///   Superscript (Sub-Superscript function).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.SubSuperscript.SuperArgument))]
  public SuperArgument? SuperArgument
  {
    get => _SuperArgument ??= GetProperty<SuperArgument?>(GetUpdatableElement()?.SuperArgument);
    set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument));
  }

  private SuperArgument? _SuperArgument;
}