namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Numeric Point.
/// </summary>
public interface NumericPoint: IModelElement
{
  /// <summary>
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }
  /// <summary>
  ///   Number Format
  /// </summary>
  public string? FormatCode { get; set; }
  /// <summary>
  ///   Numeric Value.
  /// </summary>
  public string? NumericValue { get; set; }
}