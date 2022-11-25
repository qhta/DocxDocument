namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableCellBorders Class.
/// </summary>
public interface ITableCellBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Cell Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? InsideVerticalBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopLeftToBottomRightCellBorder { get ; set; }
  
  /// <summary>
  /// Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopRightToBottomLeftCellBorder { get ; set; }
  
}
