namespace DocumentModel.Drawing.Charts;

/// <summary>
/// String Literal.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStrDataExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public class StringLiteral: IStringLiteral
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public IPointCount? PointCount
  {
    get;
    set;
  }
  
}
