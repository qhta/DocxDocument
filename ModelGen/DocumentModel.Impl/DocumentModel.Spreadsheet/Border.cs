namespace DocumentModel.Spreadsheet;

/// <summary>
/// Border Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IStartBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IEndBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRightBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDiagonalBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IVerticalBorder))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IHorizontalBorder))]
public class Border: IBorder
{
  /// <summary>
  /// Diagonal Up
  /// </summary>
  public bool? DiagonalUp
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagonal Down
  /// </summary>
  public bool? DiagonalDown
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline
  /// </summary>
  public bool? Outline
  {
    get;
    set;
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IStartBorder? StartBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IEndBorder? EndBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Spreadsheet.ILeftBorder? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IRightBorder? RightBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Spreadsheet.ITopBorder? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Spreadsheet.IBottomBorder? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Diagonal.
  /// </summary>
  public IDiagonalBorder? DiagonalBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Inner Border.
  /// </summary>
  public IVerticalBorder? VerticalBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Inner Borders.
  /// </summary>
  public IHorizontalBorder? HorizontalBorder
  {
    get;
    set;
  }
  
}
