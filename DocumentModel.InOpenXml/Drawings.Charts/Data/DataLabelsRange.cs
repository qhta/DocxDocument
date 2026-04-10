namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a range of data labels in a chart, defined by a formula and an associated cache.
///   This class allows referencing a cell range for data labels and storing cached values for efficient access and rendering.
/// </summary>
[OpenXmlType(typeof(DXO13DC.DataLabelsRange))]
[XmlRoot("DataLabelsRange", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataLabelsRange : ModelElement<DXO13DC.DataLabelsRange>
{
 /// <summary>
 ///   Formula that defines the cell range used for the data labels.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelsRange.Formula))]
 public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

 private string? _Formula;
 /// <summary>
 ///   Cache containing the values and metadata for the data labels range.
 /// </summary>
 [OpenXmlElement(typeof(DXO13DC.DataLabelsRangeChache))]
 public DataLabelsRangeCache? DataLabelsRangeCache { get => _DataLabelsRangeCache; set => UpdateField(ref _DataLabelsRangeCache, value, nameof(DataLabelsRangeCache)); }

 private DataLabelsRangeCache? _DataLabelsRangeCache;
}