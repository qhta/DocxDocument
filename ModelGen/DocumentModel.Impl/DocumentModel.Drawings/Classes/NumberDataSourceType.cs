namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public class NumberDataSourceTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType>, NumberDataSourceType
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
