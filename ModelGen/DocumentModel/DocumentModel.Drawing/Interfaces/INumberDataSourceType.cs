namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public interface INumberDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public INumberLiteral? NumberLiteral { get ; set; }
  
}
