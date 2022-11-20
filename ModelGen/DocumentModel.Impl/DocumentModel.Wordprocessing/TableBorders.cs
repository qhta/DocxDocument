namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStartBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsideHorizontalBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsideVerticalBorder))]
public class TableBorders: ITableBorders
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IStartBorder? StartBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IRightBorder? RightBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IEndBorder? EndBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IInsideHorizontalBorder? InsideHorizontalBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IInsideVerticalBorder? InsideVerticalBorder
  {
    get;
    set;
  }
  
}
