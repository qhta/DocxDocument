namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the StringLevel Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.StringLevel))]
[XmlRoot("StringLevel", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class StringLevel : ModelElement<DXO16DCD.StringLevel>
{
 /// <summary>
 /// Specifies the pt count.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.StringLevel.PtCount))]
 public UInt32? PtCount { get => _PtCount; set => UpdateField(ref _PtCount, value, nameof(PtCount)); }
 private UInt32? _PtCount;

 /// <summary>
 /// Specifies the name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.StringLevel.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 /// Specifies the chart string values.
 /// </summary>
 public ListOf<UInt32>? ChartStringValues { get => _ChartStringValues; set => UpdateField(ref _ChartStringValues, value, nameof(ChartStringValues)); }
 private ListOf<UInt32>? _ChartStringValues;
}