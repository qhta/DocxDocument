namespace DocumentModel.Drawing;

/// <summary>
/// Table Cell Properties.
/// </summary>
public interface ITableCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Left Margin
  /// </summary>
  public System.Int32? LeftMargin { get ; set; }
  
  /// <summary>
  /// Right Margin
  /// </summary>
  public System.Int32? RightMargin { get ; set; }
  
  /// <summary>
  /// Top Margin
  /// </summary>
  public System.Int32? TopMargin { get ; set; }
  
  /// <summary>
  /// Bottom Margin
  /// </summary>
  public System.Int32? BottomMargin { get ; set; }
  
  /// <summary>
  /// Text Direction
  /// </summary>
  public DocumentModel.Drawing.TextVerticalKind? Vertical { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public DocumentModel.Drawing.TextAnchoringTypeKind? Anchor { get ; set; }
  
  /// <summary>
  /// Anchor Center
  /// </summary>
  public System.Boolean? AnchorCenter { get ; set; }
  
  /// <summary>
  /// Horizontal Overflow
  /// </summary>
  public DocumentModel.Drawing.TextHorizontalOverflowKind? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Left Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? LeftBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Right Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? RightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Top Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? TopBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Bottom Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? BottomBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Top-Left to Bottom-Right Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? TopLeftToBottomRightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Bottom-Left to Top-Right Border Line Properties.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? BottomLeftToTopRightBorderLineProperties { get ; set; }
  
  /// <summary>
  /// Cell 3-D.
  /// </summary>
  public DocumentModel.Drawing.ICell3DProperties? Cell3DProperties { get ; set; }
  
}
