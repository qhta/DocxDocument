namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public interface INumberDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawing.INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawing.INumberLiteral? NumberLiteral { get ; set; }
  
}
