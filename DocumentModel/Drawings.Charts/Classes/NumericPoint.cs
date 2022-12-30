namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Numeric Point.
/// </summary>
public partial class NumericPoint
{
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index { get; set; }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public String? FormatCode { get; set; }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public String? NumericValue { get; set; }
  
}
