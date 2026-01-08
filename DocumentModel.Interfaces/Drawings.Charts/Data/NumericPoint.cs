namespace DocumentModel.Drawings.Charts;
  
/// <summary>
///   Represents a numeric data point in a chart.
/// </summary>
public interface NumericPoint: CollectionItem
{
  /// <summary>
  ///   Index of the numeric point.
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Format code for the numeric value.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Numeric value of the point.
  /// </summary>
  public string? NumericValue { get; set; }
}