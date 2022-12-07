namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public interface NumberDataSourceType
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public NumberReference? NumberReference { get ; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public NumberLiteral? NumberLiteral { get ; set; }
  
}
