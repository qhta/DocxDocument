namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NumericValue Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.NumericValue))]
[XmlRoot("NumericValue", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class NumericValue : ModelElement<DXO16DCD.NumericValue>
{
 /// <summary>
 /// Specifies the idx.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.NumericValue.Idx))]
 public UInt32? Idx { get => _Idx; set => UpdateField(ref _Idx, value, nameof(Idx)); }
 private UInt32? _Idx;
}