namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public interface NumberDataType:
{
  /// <summary>
  ///   Format Code.
  /// </summary>
  public string? FormatCode { get; set; }
  /// <summary>
  ///   Point Count.
  /// </summary>
  public UInt32? PointCount { get; set; }
}