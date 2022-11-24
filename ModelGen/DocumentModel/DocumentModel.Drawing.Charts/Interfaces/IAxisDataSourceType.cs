namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public interface IAxisDataSourceType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public IMultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public INumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public INumberLiteral? NumberLiteral { get ; set; }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public IStringReference? StringReference { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public IStringLiteral? StringLiteral { get ; set; }
  
}
