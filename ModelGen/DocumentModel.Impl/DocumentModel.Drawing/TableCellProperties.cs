namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICell3DProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILeftBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IRightBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITopBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBottomBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITopLeftToBottomRightBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBottomLeftToTopRightBorderLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
public class TableCellProperties: ITableCellProperties
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public int? LeftMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public int? RightMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Margin
  /// </summary>
  public int? TopMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Margin
  /// </summary>
  public int? BottomMargin
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Direction
  /// </summary>
  public TextVerticalValues? Vertical
  {
    get;
    set;
  }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringTypeValues? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public bool? AnchorCenter
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowValues? HorizontalOverflow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Border Line Properties.
  /// </summary>
  public ILeftBorderLineProperties? LeftBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Border Line Properties.
  /// </summary>
  public IRightBorderLineProperties? RightBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top Border Line Properties.
  /// </summary>
  public ITopBorderLineProperties? TopBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border Line Properties.
  /// </summary>
  public IBottomBorderLineProperties? BottomBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Top-Left to Bottom-Right Border Line Properties.
  /// </summary>
  public ITopLeftToBottomRightBorderLineProperties? TopLeftToBottomRightBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom-Left to Top-Right Border Line Properties.
  /// </summary>
  public IBottomLeftToTopRightBorderLineProperties? BottomLeftToTopRightBorderLineProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell 3-D.
  /// </summary>
  public ICell3DProperties? Cell3DProperties
  {
    get;
    set;
  }
  
}
