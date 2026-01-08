namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents base data for a string data source type (version 3).
/// </summary>
public interface StringDataType3
{
  /// <summary>
  ///   Number of points in the string data set.
  /// </summary>
  public UInt32? PointCount { get; set; }
}