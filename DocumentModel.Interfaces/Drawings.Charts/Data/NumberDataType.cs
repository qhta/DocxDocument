namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents base data for a numeric data source type.
/// </summary>
public interface NumberDataType
{
  /// <summary>
  ///   Format code applied to the numeric data.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Number of points in the data set.
  /// </summary>
  public UInt32? PointCount { get; set; }
}