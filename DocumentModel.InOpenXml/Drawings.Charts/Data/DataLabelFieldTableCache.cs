namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a cache of data label field table values for a chart.
///   This class provides storage for the number of points, the string values for each point, and any associated extension data.
///   The cache is used to optimize access to custom data label fields and their values.
/// </summary>
[OpenXmlType(typeof(DXO13DC.DataLabelFieldTableCache))]
[XmlRoot("DataLabelFieldTableCache", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataLabelFieldTableCache : ModelElement<DXO13DC.DataLabelFieldTableCache>
{
 /// <summary>
 ///   Number of data points represented in the field table cache.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelFieldTableCache.PointCount))]
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