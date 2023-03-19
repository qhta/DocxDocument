namespace DocumentModel.Drawings.Charts;

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
  public String? NumericValue { get; set; }
}