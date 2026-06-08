namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Numeric IPoint.
/// </summary>
public class NumericPoint: ModelElement
{
  /// <summary>
  ///   IIndex
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   Number Format
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Numeric Value.
  /// </summary>
  public string? NumericValue { get; set; }
}
