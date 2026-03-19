namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Border objects that represent the borders of an object.
/// </summary>
public partial interface Borders : InteropObject, InteropCollection<Border>
{
  /// <summary>
  /// The enable.
  /// </summary>
  public int Enable { get; set; }

  /// <summary>
  /// The distance from top.
  /// </summary>
  public int DistanceFromTop { get; set; }

  /// <summary>
  /// The shadow.
  /// </summary>
  public bool Shadow { get; set; }

  /// <summary>
  /// The inside line style.
  /// </summary>
  public WdLineStyle InsideLineStyle { get; set; }

  /// <summary>
  /// The outside line style.
  /// </summary>
  public WdLineStyle OutsideLineStyle { get; set; }

  /// <summary>
  /// The inside line width.
  /// </summary>
  public WdLineWidth InsideLineWidth { get; set; }

  /// <summary>
  /// The outside line width.
  /// </summary>
  public WdLineWidth OutsideLineWidth { get; set; }

  /// <summary>
  /// The inside color index.
  /// </summary>
  public WdColorIndex InsideColorIndex { get; set; }

  /// <summary>
  /// The outside color index.
  /// </summary>
  public WdColorIndex OutsideColorIndex { get; set; }

  /// <summary>
  /// The distance from left.
  /// </summary>
  public int DistanceFromLeft { get; set; }

  /// <summary>
  /// The distance from bottom.
  /// </summary>
  public int DistanceFromBottom { get; set; }

  /// <summary>
  /// The distance from right.
  /// </summary>
  public int DistanceFromRight { get; set; }

  /// <summary>
  /// The always in front.
  /// </summary>
  public bool AlwaysInFront { get; set; }

  /// <summary>
  /// The surround header.
  /// </summary>
  public bool SurroundHeader { get; set; }

  /// <summary>
  /// The surround footer.
  /// </summary>
  public bool SurroundFooter { get; set; }

  /// <summary>
  /// The join borders.
  /// </summary>
  public bool JoinBorders { get; set; }

  /// <summary>
  /// The has horizontal.
  /// </summary>
  public bool HasHorizontal { get; }

  /// <summary>
  /// The has vertical.
  /// </summary>
  public bool HasVertical { get; }

  /// <summary>
  /// The distance from.
  /// </summary>
  public WdBorderDistanceFrom DistanceFrom { get; set; }

  /// <summary>
  /// The enable first page in section.
  /// </summary>
  public bool EnableFirstPageInSection { get; set; }

  /// <summary>
  /// The enable other pages in section.
  /// </summary>
  public bool EnableOtherPagesInSection { get; set; }

  /// <summary>
  /// The inside color.
  /// </summary>
  public WdColor InsideColor { get; set; }

  /// <summary>
  /// The outside color.
  /// </summary>
  public WdColor OutsideColor { get; set; }
}
