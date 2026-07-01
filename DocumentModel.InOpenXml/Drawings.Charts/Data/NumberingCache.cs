namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a cache of numeric values for a chart data source.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberingCache))]
[DataContract]
[XmlRoot("NumberingCache", Namespace = "DocumentModel.Drawings.Charts")]
public partial class NumberingCache : ModelElement<DXDC.NumberingCache>
{
 /// <summary>
 ///   Format code applied to the cached numeric values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberingCache.FormatCode))]
 public string? FormatCode { get => _FormatCode; set => UpdateField(ref _FormatCode, value, nameof(FormatCode)); }
 private string? _FormatCode;

 /// <summary>
 ///   Number of numeric points in the cache.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberingCache.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }
 private UInt32? _PointCount;

 /// <summary>
 ///   Collection of numeric points stored in the cache.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumericPoint))]
 public NumericPoints? NumericPoints { get => _NumericPoints; set => UpdateField(ref _NumericPoints, value, nameof(NumericPoints)); }
 private NumericPoints? _NumericPoints;

 /// <summary>
 ///   Collection of extension elements for additional cache customization.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}