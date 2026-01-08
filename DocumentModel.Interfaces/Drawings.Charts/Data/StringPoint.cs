namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a single string data point in a chart.
/// </summary>
public interface StringPoint: CollectionItem
{
  /// <summary>
  ///   Index of the string point within the collection.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Text value of the string point.
  /// </summary>
  public string? NumericValue { get; set; }
}