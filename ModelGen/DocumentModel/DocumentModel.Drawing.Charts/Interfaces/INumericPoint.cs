namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Numeric Point.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumericValue))]
public interface INumericPoint // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Number Format
  /// </summary>
  public string? FormatCode { get ; set; }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumericValue? NumericValue { get ; set; }
  
}
