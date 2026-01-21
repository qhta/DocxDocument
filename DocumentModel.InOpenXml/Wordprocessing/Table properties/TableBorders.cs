namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the set of borders for a table in a Wordprocessing document.
/// This interface provides properties for configuring the top, left, start, bottom, right, end, inside horizontal, and inside vertical borders, enabling advanced formatting and appearance control for table edges and internal lines.
/// </summary>
public partial class TableBorders : ModelElement<DXW.TableBorders>
{
  /// <summary>
  /// Table top border, specifying the style and appearance of the top edge of the table.
  /// </summary>
  public Border? TopBorder { get; set; }
  /// <summary>
  /// Table left border, specifying the style and appearance of the left edge of the table.
  /// </summary>
  public Border? LeftBorder { get; set; }
  /// <summary>
  /// Start border, specifying the style and appearance of the starting edge of the table (contextual to document direction).
  /// </summary>
  public Border? StartBorder { get; set; }
  /// <summary>
  /// Table bottom border, specifying the style and appearance of the bottom edge of the table.
  /// </summary>
  public Border? BottomBorder { get; set; }
  /// <summary>
  /// Table right border, specifying the style and appearance of the right edge of the table.
  /// </summary>
  public Border? RightBorder { get; set; }
  /// <summary>
  /// End border, specifying the style and appearance of the ending edge of the table (contextual to document direction).
  /// </summary>
  public Border? EndBorder { get; set; }
  /// <summary>
  /// Table inside horizontal edges border, specifying the style and appearance of horizontal lines between rows.
  /// </summary>
  public Border? InsideHorizontalBorder { get; set; }
  /// <summary>
  /// Table inside vertical edges border, specifying the style and appearance of vertical lines between columns.
  /// </summary>
  public Border? InsideVerticalBorder { get; set; }
}