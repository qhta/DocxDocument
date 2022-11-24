namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public interface ITableBorders // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IStartBorder? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public IEndBorder? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public InsideHorizontalBorder? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public InsideVerticalBorder? InsideVerticalBorder { get ; set; }
  
}
