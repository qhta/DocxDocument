namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the YValues Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberReference))]
public class YValues: IYValues
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
