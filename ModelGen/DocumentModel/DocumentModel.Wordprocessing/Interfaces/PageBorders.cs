namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public interface PageBorders
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderZOrderKind? ZOrder { get ; set; }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderDisplayKind? Display { get ; set; }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public DocumentModel.Wordprocessing.PageBorderOffsetKind? OffsetFrom { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder { get ; set; }
  
}
