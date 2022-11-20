namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ISlicerStyle))]
public class SlicerStyles: ISlicerStyles
{
  /// <summary>
  /// defaultSlicerStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public string? DefaultSlicerStyle
  {
    get;
    set;
  }
  
}
