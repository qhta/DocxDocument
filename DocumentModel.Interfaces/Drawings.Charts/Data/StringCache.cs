namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of string values for a chart data source.
///   This interface stores the number of points, the actual string points, and any extension data associated with the string cache.
/// </summary>
public interface StringCache
{
  /// <summary>
  ///   Number of string points stored in the cache.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of string points containing the cached values.
  /// </summary>
  public StringPoints StringPoints { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional string data properties.
  /// </summary>
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}