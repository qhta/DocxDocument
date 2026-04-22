namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the TextData Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.TextData))]
[XmlRoot("TextData", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class TextData : ModelElement<DXO16DCD.TextData>
{
  /// <summary>
  /// Specifies the formula.
  /// </summary>
  public OpenXmlFormulaElement? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

  private OpenXmlFormulaElement? _Formula;
  /// <summary>
  /// Specifies the v xsd string.
  /// </summary>
  public string? VXsdString { get => _VXsdString; set => UpdateField(ref _VXsdString, value, nameof(VXsdString)); }

  private string? _VXsdString;
}