namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NumberFormat Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.NumberFormat))]
[XmlRoot("NumberFormat", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class NumberFormat : ModelElement<DXO16DCD.NumberFormat>
{
  /// <summary>
  /// Specifies the format code.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.NumberFormat.FormatCode))]
  public string? FormatCode { get => _FormatCode; set => UpdateField(ref _FormatCode, value, nameof(FormatCode)); }

  private string? _FormatCode;
  /// <summary>
  /// Specifies the source linked.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.NumberFormat.SourceLinked))]
  public bool? SourceLinked { get => _SourceLinked; set => UpdateField(ref _SourceLinked, value, nameof(SourceLinked)); }

  private bool? _SourceLinked;
}