namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.Description))]
public partial class Description : ModelElement<DXDD.Description>
{
  /// <summary>
  ///   Language
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Description.Language))]
  public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }
  private string? _Language;
  /// <summary>
  ///   Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Description.Val))]
  public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
  private string? _Val;
}