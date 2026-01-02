namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public class NumberDataType: ModelElement
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