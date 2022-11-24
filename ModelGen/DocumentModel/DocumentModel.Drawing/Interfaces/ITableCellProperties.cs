namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Properties.
/// </summary>
public interface ITableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public Int32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public Int32? RightMargin { get ; set; }
  
  /// <summary>
  /// Top Margin
  /// </summary>
  public Int32? TopMargin { get ; set; }
  
  /// <summary>
  /// Bottom Margin
  /// </summary>
  public Int32? BottomMargin { get ; set; }
  
  /// <summary>
  /// Text Direction
  /// </summary>
  public TextVerticalValues? Vertical { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringTypeValues? Anchor { get ; set; }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public Boolean? AnchorCenter { get ; set; }
  
  /// <summary>
  /// Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowValues? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Left Border Line Properties.
  /// </summary>
  public ILeftBorderLineProperties? LeftBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Right Border Line Properties.
  /// </summary>
  public IRightBorderLineProperties? RightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Top Border Line Properties.
  /// </summary>
  public ITopBorderLineProperties? TopBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Bottom Border Line Properties.
  /// </summary>
  public IBottomBorderLineProperties? BottomBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Top-Left to Bottom-Right Border Line Properties.
  /// </summary>
  public ITopLeftToBottomRightBorderLineProperties? TopLeftToBottomRightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Bottom-Left to Top-Right Border Line Properties.
  /// </summary>
  public IBottomLeftToTopRightBorderLineProperties? BottomLeftToTopRightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Cell 3-D.
  /// </summary>
  public ICell3DProperties? Cell3DProperties { get ; set; }
  
}
