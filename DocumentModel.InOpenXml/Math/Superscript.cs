namespace DocumentModel.Math;

/// <summary>
///   Superscript Function.
/// </summary>
[OpenXmlType(typeof(DXM.Superscript))]
[DataContract]
[XmlRoot("Superscript", Namespace = "DocumentModel.Math")]
public partial class Superscript: ModelElement<DXM.Superscript>, ICommonMathContent
{
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Superscript.SuperscriptProperties))]
  public SuperscriptProperties? SuperscriptProperties
  {
    get => _SuperscriptProperties ??= GetProperty<SuperscriptProperties?>(GetUpdatableElement()?.SuperscriptProperties);
    set => UpdateField(ref _SuperscriptProperties, value, nameof(SuperscriptProperties));
  }

  private SuperscriptProperties? _SuperscriptProperties;

  /// <summary>
  ///   Specifies the argument of superscript function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Superscript.Base))]
  public Base? Base
  {
    get => _Base ??= GetProperty<Base?>(GetUpdatableElement()?.Base);
    set => UpdateField(ref _Base, value, nameof(Base));
  }

  private Base? _Base;

  /// <summary>
  ///   Superscript (Superscript function).
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Superscript.SuperArgument))]
  public SuperArgument? SuperArgument
  {
    get => _SuperArgument ??= GetProperty<SuperArgument?>(GetUpdatableElement()?.SuperArgument);
    set => UpdateField(ref _SuperArgument, value, nameof(SuperArgument));
  }

  private SuperArgument? _SuperArgument;
}