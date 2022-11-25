namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public interface INumberDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberDataType? NumberLiteral { get ; set; }
  
}
