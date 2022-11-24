namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Numeric Point.
/// </summary>
public interface INumericPoint // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public INumericValue? NumericValue { get ; set; }
  
}
