namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public interface ITableBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public IBorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public IBorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorderType? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public IBorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public IBorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IBorderType? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public IBorderType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public IBorderType? InsideVerticalBorder { get ; set; }
  
}
