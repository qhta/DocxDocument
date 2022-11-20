namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMultiLevelStringReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.INumberReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringLiteral))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringReference))]
public class CategoryAxisData: ICategoryAxisData
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public IMultiLevelStringReference? MultiLevelStringReference
  {
    get;
    set;
  }
  
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
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public IStringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public IStringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
