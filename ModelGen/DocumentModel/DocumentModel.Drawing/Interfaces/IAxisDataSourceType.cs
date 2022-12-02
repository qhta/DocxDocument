namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public interface IAxisDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public DocumentModel.Drawing.IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawing.IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawing.IStringLiteral? StringLiteral { get ; set; }
  
}
