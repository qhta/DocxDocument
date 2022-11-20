namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public class MultiLevelStringCache: IMultiLevelStringCache
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
