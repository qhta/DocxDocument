namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public interface ITableCellBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Left Border.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartBorder? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Right Border.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndBorder? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public InsideHorizontalBorder? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  public InsideVerticalBorder? InsideVerticalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public ITopLeftToBottomRightCellBorder? TopLeftToBottomRightCellBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public ITopRightToBottomLeftCellBorder? TopRightToBottomLeftCellBorder { get ; set; }
  
}
