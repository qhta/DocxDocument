namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a row in a table.
/// </summary>
/// <remarks>
///   A Row is a horizontal series of cells in a table. Rows can have properties
///   that control height, whether they can break across pages, and whether they
///   should be repeated as header rows.
/// </remarks>
public interface Row
{
  #region Properties

  /// <summary>
  ///   Gets or sets the table row properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get; set; }

  /// <summary>
  ///   Gets or sets the height of the row.
  /// </summary>
  public Twips? Height { get; set; }

  /// <summary>
  ///   Gets or sets the height rule for the row.
  /// </summary>
  public HeightRuleKind? HeightRule { get; set; }

  /// <summary>
  ///   Gets or sets whether the row is a header row.
  /// </summary>
  /// <remarks>
  ///   Header rows are repeated at the top of each page when a table spans multiple pages.
  /// </remarks>
  public bool? IsHeader { get; set; }

  /// <summary>
  ///   Gets or sets whether the row can break across pages.
  /// </summary>
  public bool? AllowBreakAcrossPages { get; set; }

  #endregion

  #region Position

  /// <summary>
  ///   Gets the index of the row in the table.
  /// </summary>
  public int Index { get; }

  /// <summary>
  ///   Gets the parent table.
  /// </summary>
  public Table? Table { get; }

  /// <summary>
  ///   Gets the next row.
  /// </summary>
  public Row? Next { get; }

  /// <summary>
  ///   Gets the previous row.
  /// </summary>
  public Row? Previous { get; }

  #endregion

  #region Cells

  /// <summary>
  ///   Gets the collection of cells in the row.
  /// </summary>
  public Cells? Cells { get; }

  /// <summary>
  ///   Gets the range representing the row's content.
  /// </summary>
  public Range? Range { get; }

  #endregion

  #region Methods

  /// <summary>
  ///   Selects the row.
  /// </summary>
  public void Select();

  /// <summary>
  ///   Deletes the row from the table.
  /// </summary>
  public void Delete();

  /// <summary>
  ///   Converts the row to text.
  /// </summary>
  /// <param name="separator">Optional separator character.</param>
  /// <returns>Range containing the converted text.</returns>
  public Range? ConvertToText(string? separator = null);

  /// <summary>
  ///   Sets the height of the row.
  /// </summary>
  /// <param name="height">Height in points.</param>
  /// <param name="heightRule">Height rule.</param>
  public void SetHeight(float height, HeightRuleKind heightRule);

  #endregion

  #region Parent and Application

  /// <summary>
  ///   Gets the parent object.
  /// </summary>
  public object? Parent { get; }

  /// <summary>
  ///   Gets the application object.
  /// </summary>
  public Application? Application { get; }

  #endregion
}