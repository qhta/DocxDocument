namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public interface IAxisDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataType? NumberLiteral { get ; set; }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawing.Charts.IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawing.Charts.IStringDataType? StringLiteral { get ; set; }
  
}
