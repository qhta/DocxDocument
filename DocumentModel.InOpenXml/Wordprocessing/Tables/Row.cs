namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a row in a table within a Wordprocessing document.
/// This class provides properties and methods for configuring row formatting, height, header status, page break behavior, cell collection, and for manipulating and querying the row's position and relationships within the table structure.
/// </summary>
/// <remarks>
/// 
/// A Row is a horizontal series of cells in a table. Rows can have properties that control height, whether they can break across pages, and whether they should be repeated as header rows.
/// 
/// </remarks>
public partial interface Row
{
  #region Properties

  /// <summary>
  /// Table row properties, including formatting and layout options for the row.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }

  /// <summary>
  /// Height of the row.
  /// </summary>
  public Twips? Height { get; set; }

  /// <summary>
  /// Height rule for the row, specifying whether the height is at least, exactly, or auto.
  /// </summary>
  public HeightMeasureType? HeightRule { get; set; }

  /// <summary>
  /// Whether the row is a header row. Header rows are repeated at the top of each page when a table spans multiple pages.
  /// </summary>
  public bool? IsHeader { get; set; }

  /// <summary>
  /// Whether the row can break across pages.
  /// </summary>
  public bool? AllowBreakAcrossPages { get; set; }

  #endregion

  #region Position

  /// <summary>
  /// Index of the row in the table.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// Parent table containing this row.
  /// </summary>
  public Table? Table { get; }

  /// <summary>
  /// Next row in the table.
  /// </summary>
  public Row? Next { get; }

  /// <summary>
  /// Previous row in the table.
  /// </summary>
  public Row? Previous { get; }

  #endregion

  #region Cells

  /// <summary>
  /// Collection of cells in the row.
  /// </summary>
  public IEnumerable<TableCell>? Cells { get; }

  /// <summary>
  /// Range representing the row's content.
  /// </summary>
  public Range? Range { get; }

  #endregion

}