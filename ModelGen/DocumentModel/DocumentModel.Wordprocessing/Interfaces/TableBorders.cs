namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public interface TableBorders
{
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? StartBorder { get ; set; }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get ; set; }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? EndBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideVerticalBorder { get ; set; }
  
}
