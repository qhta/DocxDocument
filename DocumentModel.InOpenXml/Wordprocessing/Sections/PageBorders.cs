namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page borders settings for a section in a Wordprocessing document.
/// This class provides properties for z-ordering, display options, border positioning, and individual borders for each page edge, enabling advanced configuration of page border appearance and behavior.
/// </summary>
public class PageBorders : ModelElement<DXW.PageBorders>, ISectionPropertiesContent
{
  
  /// <summary>
  /// Z-ordering of the page border, specifying the stacking order relative to other elements.
  /// </summary>
  public PageBorderZOrderKind? ZOrder { get; set; }
  
  /// <summary>
  /// Pages to display page borders, specifying which pages the borders are shown on.
  /// </summary>
  public PageBorderDisplayKind? Display { get; set; }
  
  /// <summary>
  /// Page border positioning, specifying the offset from the page edge.
  /// </summary>
  public PageBorderOffsetKind? OffsetFrom { get; set; }
  
  /// <summary>
  /// Top border of the page, specifying the style and appearance of the top edge.
  /// </summary>
  public Border? TopBorder { get; set; }
  
  /// <summary>
  /// Left border of the page, specifying the style and appearance of the left edge.
  /// </summary>
  public Border? LeftBorder { get; set; }
  
  /// <summary>
  /// Bottom border of the page, specifying the style and appearance of the bottom edge.
  /// </summary>
  public Border? BottomBorder { get; set; }
  
  /// <summary>
  /// Right border of the page, specifying the style and appearance of the right edge.
  /// </summary>
  public Border? RightBorder { get; set; }
}