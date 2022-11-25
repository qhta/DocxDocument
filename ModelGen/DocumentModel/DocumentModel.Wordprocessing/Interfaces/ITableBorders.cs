namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public interface ITableBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.IBorderType? InsideVerticalBorder { get ; set; }
  
}
