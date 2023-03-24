namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public class NumberDataType: ModelElement
{
  /// <summary>
  ///   Format Code.
  /// </summary>
  public String? FormatCode { get; set; }

  /// <summary>
  ///   Point Count.
  /// </summary>
  public UInt32? PointCount { get; set; }
}