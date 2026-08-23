namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of multi-level string values for a chart.
/// </summary>
[OpenXmlType(typeof(DXDC.MultiLevelStringCache))]
[DataContract]
[XmlRoot("MultiLevelStringCache", Namespace = "DocumentModel.Drawings.Charts")]
public partial class MultiLevelStringCache: ModelElement<DXDC.MultiLevelStringCache>
{
  /// <summary>
  ///   Number of points in the cache.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.MultiLevelStringCache.PointCount))]
  public UInt32? PointCount
  {
    get => _PointCount ??= GetProperty<UInt32?>(GetUpdatableElement()?.PointCount);
    set => UpdateField(ref _PointCount, value, nameof(PointCount));
  }

  private UInt32? _PointCount;

  /// <summary>
  ///   Collection of levels defining the hierarchical string data.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Level))]
  public Levels? Levels
  {
    get => _Levels ??= GetElement<Levels, DXDC.Level>(GetUpdatableElement());
    set => UpdateField(ref _Levels, value, nameof(Levels));
  }

  private Levels? _Levels;

  /// <summary>
  ///   Collection of extension elements for additional cache customization.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDC.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}