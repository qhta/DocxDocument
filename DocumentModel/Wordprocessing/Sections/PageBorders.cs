namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public class PageBorders: ModelElement, ISectionPropertiesContent
{
  /// <summary>
  ///   Z-Ordering of IPage IBorder
  /// </summary>
  public PageBorderZOrderKind? ZOrder { get; set; }

  /// <summary>
  ///   IPages Ito Display IPage IBorders
  /// </summary>
  public PageBorderDisplayKind? Display { get; set; }

  /// <summary>
  ///   IPage IBorder Positioning
  /// </summary>
  public PageBorderOffsetKind? OffsetFrom { get; set; }

  /// <summary>
  ///   Top IBorder.
  /// </summary>
  public IBorder? TopBorder { get; set; }

  /// <summary>
  ///   Left IBorder.
  /// </summary>
  public IBorder? LeftBorder { get; set; }

  /// <summary>
  ///   Bottom IBorder.
  /// </summary>
  public IBorder? BottomBorder { get; set; }

  /// <summary>
  ///   Right IBorder.
  /// </summary>
  public IBorder? RightBorder { get; set; }
}
