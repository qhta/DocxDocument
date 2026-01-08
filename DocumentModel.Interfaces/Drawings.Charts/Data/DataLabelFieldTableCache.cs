namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of data label field table values for a chart.
///   This interface provides storage for the number of points, the string values for each point, and any associated extension data.
///   The cache is used to optimize access to custom data label fields and their values.
/// </summary>
public interface DataLabelFieldTableCache
{
  /// <summary>
  ///   Number of data points represented in the field table cache.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of string values for each data point in the cache.
  /// </summary>
  public StringPoints? StringPoints { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional cache customization or metadata.
  /// </summary>
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}