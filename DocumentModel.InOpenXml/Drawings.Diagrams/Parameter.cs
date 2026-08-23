namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Parameter.
/// </summary>
[OpenXmlType(typeof(DXDD.Parameter))]
[DataContract]
[XmlRoot("Parameter", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Parameter: ModelElement<DXDD.Parameter>
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Parameter.Type))]
  public ParameterId? Type
  {
    get => _Type ??= GetProperty<ParameterId?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private ParameterId? _Type;

  /// <summary>
  ///   Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Parameter.Val))]
  public string? Val
  {
    get => _Val ??= GetProperty<string?>(GetUpdatableElement()?.Val);
    set => UpdateField(ref _Val, value, nameof(Val));
  }

  private string? _Val;
}