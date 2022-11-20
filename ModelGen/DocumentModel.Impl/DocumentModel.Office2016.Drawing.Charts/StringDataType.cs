namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStrDataExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStringPoint))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public class StringDataType: IStringDataType
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
