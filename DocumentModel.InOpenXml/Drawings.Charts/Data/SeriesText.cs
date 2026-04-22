namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents text associated with a chart series.
///   This class defines either a reference to a string data source or a direct numeric value used as text.
/// </summary>
[OpenXmlType(typeof(DXDC.SeriesText))]
[XmlRoot("SeriesText", Namespace = "DocumentModel.Drawings.Charts")]
public partial class SeriesText : ModelElement<DXDC.SeriesText>
{
 /// <summary>
 ///   Reference to a string data source used for the series text.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.SeriesText.StringReference))]
 public StringReference? StringReference { get => _StringReference; set => UpdateField(ref _StringReference, value, nameof(StringReference)); }
 private StringReference? _StringReference;

 /// <summary>
 ///   Numeric value displayed as text for the series.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.SeriesText.NumericValue))]
 public string? NumericValue { get => _NumericValue; set => UpdateField(ref _NumericValue, value, nameof(NumericValue)); }
 private string? _NumericValue;
}