namespace DocumentModel.Drawing;

/// <summary>
/// Numeric Point.
/// </summary>
public interface INumericPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public System.String? FormatCode { get ; set; }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public System.String? NumericValue { get ; set; }
  
}
