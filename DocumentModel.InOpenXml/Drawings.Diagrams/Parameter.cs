namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Parameter.
/// </summary>
[OpenXmlType(typeof(DXDD.Parameter))]
public partial class Parameter : ModelElement<DXDD.Parameter>
{
  /// <summary>
  ///   Parameter Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Parameter.Type))]
  public ParameterId? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

  private ParameterId? _Type;
  /// <summary>
  ///   Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Parameter.Val))]
  public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

  private string? _Val;
}