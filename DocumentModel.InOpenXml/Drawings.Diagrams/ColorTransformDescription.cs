namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformDescription))]
public partial class ColorTransformDescription : ModelElement<DXDD.ColorTransformDescription>
{
  /// <summary>
  ///   Language
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Language))]
  public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }
  private string? _Language;
  /// <summary>
  ///   Description Value
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Val))]
  public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
  private string? _Val;
}