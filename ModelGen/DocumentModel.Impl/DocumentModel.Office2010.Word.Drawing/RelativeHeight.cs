namespace DocumentModel.Office2010.Word.Drawing;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.Drawing.IPercentageHeight))]
public class RelativeHeight: IRelativeHeight
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  public SizeRelativeVerticallyValues? RelativeFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  public IPercentageHeight? PercentageHeight
  {
    get;
    set;
  }
  
}
