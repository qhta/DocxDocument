namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public interface ITableCellBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  public IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Left Border.
  /// </summary>
  public IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorderType? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  public IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Right Border.
  /// </summary>
  public IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorderType? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public IBorderType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  public IBorderType? InsideVerticalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public IBorderType? TopLeftToBottomRightCellBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public IBorderType? TopRightToBottomLeftCellBorder { get ; set; }
  
}
