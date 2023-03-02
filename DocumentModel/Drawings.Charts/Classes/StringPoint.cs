namespace DocumentModel.Drawings.Charts;

/// <summary>
///   String Point.
/// </summary>
public record StringPoint
{
  /// <summary>
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }

  /// <summary>
  ///   Text Value.
  /// </summary>
  public String? NumericValue { get; set; }
}