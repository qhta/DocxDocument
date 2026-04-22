namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a cache of values for a data labels range in a chart.
///   This class stores the number of points, the string values for each point, and any associated extension data.
///   The cache is used to optimize access to the values referenced by a data labels range formula.
/// </summary>
[OpenXmlType(typeof(DXO13DC.DataLabelsRangeChache))]
[XmlRoot("DataLabelsRangeCache", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataLabelsRangeCache : ModelElement<DXO13DC.DataLabelsRangeChache>
{
 /// <summary>
 ///   Number of data points represented in the data labels range cache.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelsRangeChache.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }
 private UInt32? _PointCount;

 /// <summary>
 ///   Collection of string values for each data point in the cache.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StringPoint))]
 public StringPoints? StringPoints { get => _StringPoints; set => UpdateField(ref _StringPoints, value, nameof(StringPoints)); }
 private StringPoints? _StringPoints;

 /// <summary>
 ///   Extension elements for additional cache customization or metadata.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StrDataExtensionList))]
 public StrDataExtension? StrDataExtension { get => _StrDataExtension; set => UpdateField(ref _StrDataExtension, value, nameof(StrDataExtension)); }
 private StrDataExtension? _StrDataExtension;
}