namespace DocumentModel.Drawings;

/// <summary>
/// Numeric Point.
/// </summary>
public interface NumericPoint // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public String? FormatCode { get ; set; }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public String? NumericValue { get ; set; }
  
}
