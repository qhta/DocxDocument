namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public class PageBorders: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Z-Ordering of Page Border
  /// </summary>
  public PageBorderZOrderKind? ZOrder { get; set; }
  /// <summary>
  ///   Pages to Display Page Borders
  /// </summary>
  public PageBorderDisplayKind? Display { get; set; }
  /// <summary>
  ///   Page Border Positioning
  /// </summary>
  public PageBorderOffsetKind? OffsetFrom { get; set; }
  /// <summary>
  ///   Top Border.
  /// </summary>
  public IBorder? TopBorder { get; set; }
  /// <summary>
  ///   Left Border.
  /// </summary>
  public IBorder? LeftBorder { get; set; }
  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public IBorder? BottomBorder { get; set; }
  /// <summary>
  ///   Right Border.
  /// </summary>
  public IBorder? RightBorder { get; set; }
}