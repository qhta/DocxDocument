namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a cache of string values for a chart data source.
///   This class stores the number of points, the actual string points, and any extension data associated with the string cache.
/// </summary>
[OpenXmlType(typeof(DXDC.StringCache))]
[XmlRoot("StringCache", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StringCache : ModelElement<DXDC.StringCache>
{
 /// <summary>
 ///   Number of string points stored in the cache.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.StringCache.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }

 private UInt32? _PointCount;
 /// <summary>
 ///   Collection of string points containing the cached values.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StringPoint))]
 public StringPoints? StringPoints { get => _StringPoints; set => UpdateField(ref _StringPoints, value, nameof(StringPoints)); }

 private StringPoints? _StringPoints;
 /// <summary>
 ///   Extension elements for additional string data properties.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StrDataExtensionList))]
 public StrDataExtension? StrDataExtension { get => _StrDataExtension; set => UpdateField(ref _StrDataExtension, value, nameof(StrDataExtension)); }

 private StrDataExtension? _StrDataExtension;
}