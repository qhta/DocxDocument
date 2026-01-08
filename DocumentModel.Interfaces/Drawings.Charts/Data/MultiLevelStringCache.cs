namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of multi-level string values for a chart.
/// </summary>
public interface MultiLevelStringCache
{
  /// <summary>
  ///   Number of points in the cache.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of levels defining the hierarchical string data.
  /// </summary>
  public Levels Levels { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional cache customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}