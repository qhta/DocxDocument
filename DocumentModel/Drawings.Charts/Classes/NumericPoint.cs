namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Numeric Point.
/// </summary>
public class NumericPoint: ModelElement
{
  /// <summary>
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Number Format
  /// </summary>
  public String? FormatCode { get; set; }

  /// <summary>
  ///   Numeric Value.
  /// </summary>
  public String? NumericValue { get; set; }
}