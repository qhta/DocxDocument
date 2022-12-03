namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public interface AxisDataSourceType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public MultiLevelStringReference? MultiLevelStringReference { get ; set; }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public NumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public NumberLiteral? NumberLiteral { get ; set; }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference { get ; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public StringLiteral? StringLiteral { get ; set; }
  
}
