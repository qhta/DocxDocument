namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStrDataExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public class StringCache: IStringCache
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
