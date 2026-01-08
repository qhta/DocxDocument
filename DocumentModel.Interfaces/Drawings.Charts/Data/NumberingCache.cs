namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of numeric values for a chart data source.
/// </summary>
public interface NumberingCache
{
  /// <summary>
  ///   Format code applied to the cached numeric values.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Number of numeric points in the cache.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of numeric points stored in the cache.
  /// </summary>
  public NumericPoints NumericPoints { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional cache customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}