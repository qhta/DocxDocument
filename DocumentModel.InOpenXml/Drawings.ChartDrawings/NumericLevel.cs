namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.NumericLevel))]
[XmlRoot("NumericLevel", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class NumericLevel : ModelElement<DXO16DCD.NumericLevel>
{
 /// <summary>
 /// Specifies the pt count.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.NumericLevel.PtCount))]
 public UInt32? PtCount { get => _PtCount; set => UpdateField(ref _PtCount, value, nameof(PtCount)); }

 private UInt32? _PtCount;
 /// <summary>
 /// Specifies the format code.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.NumericLevel.FormatCode))]
 public string? FormatCode { get => _FormatCode; set => UpdateField(ref _FormatCode, value, nameof(FormatCode)); }

 private string? _FormatCode;
 /// <summary>
 /// Specifies the name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.NumericLevel.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
}