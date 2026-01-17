namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies a set of cell margins for all cells in the parent table row 
///   via table-level property exceptions.
///   These settings can be overridden by the cell margin definition specified by the tcMar element 
///   within the table cell's properties.
/// </summary>
public class TableCellMargin: ModelElement<DXW.TableCellMargin>
{
  /// <summary>
  ///   Table cell top margin, specifying the padding at the top edge of the cell.
  /// </summary>
  public TableWidth? TopMargin { get; set; }

  /// <summary>
  ///   Table cell left margin, specifying the padding at the left edge of the cell.
  /// </summary>
  public TableWidth? LeftMargin { get; set; }

  /// <summary>
  ///   Start margin, specifying the padding at the starting edge of the cell 
  ///   (contextual to document direction).
  /// </summary>
  public TableWidth? StartMargin { get; set; }

  /// <summary>
  ///   Table cell bottom margin, specifying the padding at the bottom edge of the cell.
  /// </summary>
  public TableWidth? BottomMargin { get; set; }

  /// <summary>
  ///   Table cell right margin, specifying the padding at the right edge of the cell.
  /// </summary>
  public TableWidth? RightMargin { get; set; }

  /// <summary>
  ///   End margin, specifying the padding at the ending edge of the cell 
  ///   (contextual to document direction).
  /// </summary>
  public TableWidth? EndMargin { get; set; }
}