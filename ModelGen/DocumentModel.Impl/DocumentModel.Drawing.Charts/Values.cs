namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Values Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberReference))]
public class Values: IValues
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public INumberReference? NumberReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public INumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
}
