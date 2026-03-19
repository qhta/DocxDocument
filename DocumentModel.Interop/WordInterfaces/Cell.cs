namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table cell.
/// </summary>
public partial interface Cell : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The row index.
  /// </summary>
  public int RowIndex { get; }

  /// <summary>
  /// The column index.
  /// </summary>
  public int ColumnIndex { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  public WdCellVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  public Column Column { get; }

  /// <summary>
  /// The row.
  /// </summary>
  public Row Row { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public Cell Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Cell Previous { get; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The tables.
  /// </summary>
  public Tables Tables { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  public bool WordWrap { get; set; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The fit text.
  /// </summary>
  public bool FitText { get; set; }

  /// <summary>
  /// The top padding.
  /// </summary>
  public float TopPadding { get; set; }

  /// <summary>
  /// The bottom padding.
  /// </summary>
  public float BottomPadding { get; set; }

  /// <summary>
  /// The left padding.
  /// </summary>
  public float LeftPadding { get; set; }

  /// <summary>
  /// The right padding.
  /// </summary>
  public float RightPadding { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  public WdPreferredWidthType PreferredWidthType { get; set; }
}
