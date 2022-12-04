namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public class NumberDataSourceType
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public virtual NumberReference? NumberReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public virtual NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
}
