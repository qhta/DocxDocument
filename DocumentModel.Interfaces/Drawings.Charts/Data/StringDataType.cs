namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents base data for a string data source type.
/// </summary>
public interface StringDataType
{
  /// <summary>
  ///   Number of points in the string data set.
  /// </summary>
  public UInt32? PointCount { get; set; }
}