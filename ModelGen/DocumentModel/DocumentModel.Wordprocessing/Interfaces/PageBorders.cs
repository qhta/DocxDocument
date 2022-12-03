namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public interface PageBorders // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Z-Ordering of Page Border
  /// </summary>
  public PageBorderZOrderKind? ZOrder { get ; set; }
  
  /// <summary>
  /// Pages to Display Page Borders
  /// </summary>
  public PageBorderDisplayKind? Display { get ; set; }
  
  /// <summary>
  /// Page Border Positioning
  /// </summary>
  public PageBorderOffsetKind? OffsetFrom { get ; set; }
  
  /// <summary>
  /// Top Border.
  /// </summary>
  public BorderType? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public BorderType? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public BorderType? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public BorderType? RightBorder { get ; set; }
  
}
