namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the set of borders for a table cell in a Wordprocessing document.
/// This interface provides properties for configuring the top, left, start, bottom, right, end, inside horizontal, inside vertical, and diagonal borders, enabling advanced formatting and appearance control for cell edges and internal lines.
/// </summary>
public class TableCellBorders: ModelElement<DXW.TableCellBorders>
{
  
  /// <summary>
  /// Table cell top border, specifying the style and appearance of the top edge of the cell.
  /// </summary>
  public Border? TopBorder { get; set; }
  
  /// <summary>
  /// Table cell left border, specifying the style and appearance of the left edge of the cell.
  /// </summary>
  public Border? LeftBorder { get; set; }
  
  /// <summary>
  /// Start border, specifying the style and appearance of the starting edge of the cell (contextual to document direction).
  /// </summary>
  public Border? StartBorder { get; set; }
  
  /// <summary>
  /// Table cell bottom border, specifying the style and appearance of the bottom edge of the cell.
  /// </summary>
  public Border? BottomBorder { get; set; }
  
  /// <summary>
  /// Table cell right border, specifying the style and appearance of the right edge of the cell.
  /// </summary>
  public Border? RightBorder { get; set; }
  
  /// <summary>
  /// End border, specifying the style and appearance of the ending edge of the cell (contextual to document direction).
  /// </summary>
  public Border? EndBorder { get; set; }
  
  /// <summary>
  /// Table cell inside horizontal edges border, specifying the style and appearance of horizontal lines within the cell.
  /// </summary>
  public Border? InsideHorizontalBorder { get; set; }
  
  /// <summary>
  /// Table cell inside vertical edges border, specifying the style and appearance of vertical lines within the cell.
  /// </summary>
  public Border? InsideVerticalBorder { get; set; }
  
  /// <summary>
  /// Table cell top left to bottom right diagonal border, specifying the style and appearance of the diagonal line from top left to bottom right.
  /// </summary>
  public Border? TopLeftToBottomRightCellBorder { get; set; }
  
  /// <summary>
  /// Table cell top right to bottom left diagonal border, specifying the style and appearance of the diagonal line from top right to bottom left.
  /// </summary>
  public Border? TopRightToBottomLeftCellBorder { get; set; }
}