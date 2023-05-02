namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   String Point.
/// </summary>
public class StringPoint: ModelElement
{
  /// <summary>
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Text Value.
  /// </summary>
  public string? NumericValue { get; set; }
}