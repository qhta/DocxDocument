namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a cache of values for a data labels range in a chart.
///   This interface stores the number of points, the string values for each point, and any associated extension data.
///   The cache is used to optimize access to the values referenced by a data labels range formula.
/// </summary>
public interface DataLabelsRangeCache
{
  /// <summary>
  ///   Number of data points represented in the data labels range cache.
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