namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public class PageBorders: ModelElement, ISectionPropertiesElement
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
  public Border? TopBorder { get; set; }

  /// <summary>
  ///   Left Border.
  /// </summary>
  public Border? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom Border.
  /// </summary>
  public Border? BottomBorder { get; set; }

  /// <summary>
  ///   Right Border.
  /// </summary>
  public Border? RightBorder { get; set; }
}