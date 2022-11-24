namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorders Class.
/// </summary>
public interface IPageBorders // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public ITopBorder? TopBorder { get ; set; }
  
  /// <summary>
  /// Left Border.
  /// </summary>
  public ILeftBorder? LeftBorder { get ; set; }
  
  /// <summary>
  /// Bottom Border.
  /// </summary>
  public IBottomBorder? BottomBorder { get ; set; }
  
  /// <summary>
  /// Right Border.
  /// </summary>
  public IRightBorder? RightBorder { get ; set; }
  
}
