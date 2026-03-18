namespace DocumentModel.Interop;

/// <summary>
/// A collection of Row objects that represent the table rows in the specified selection, range, or table.
/// </summary>
public partial interface Rows : InteropObject, InteropCollection<Row>
{
  /// <summary>
  /// Indicates whether text in the row is allowed to split across page breaks.
  /// </summary>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// Alignment of rows in the table.
  /// </summary>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// Indicates whether the row is formatted as a heading row that repeats on subsequent pages.
  /// </summary>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// The amount of spacing, in points, between table columns.
  /// </summary>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// Height, in points, for the rows.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// How row height is interpreted (automatic, at least, or exactly).
  /// </summary>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// Left indent, in points, applied to the rows.
  /// </summary>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The first row in the collection.
  /// </summary>
  public Row First { get; }

  /// <summary>
  /// The last row in the collection.
  /// </summary>
  public Row Last { get; }

  /// <summary>
  /// Border formatting for the rows.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading formatting for the rows.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// Indicates whether text can wrap around the table rows.
  /// </summary>
  public int WrapAroundText { get; set; }

  /// <summary>
  /// Top distance, in points, between surrounding text and the rows.
  /// </summary>
  public float DistanceTop { get; set; }

  /// <summary>
  /// Bottom distance, in points, between surrounding text and the rows.
  /// </summary>
  public float DistanceBottom { get; set; }

  /// <summary>
  /// Left distance, in points, between surrounding text and the rows.
  /// </summary>
  public float DistanceLeft { get; set; }

  /// <summary>
  /// Right distance, in points, between surrounding text and the rows.
  /// </summary>
  public float DistanceRight { get; set; }

  /// <summary>
  /// Horizontal position, in points, of the rows relative to the anchor.
  /// </summary>
  public float HorizontalPosition { get; set; }

  /// <summary>
  /// Vertical position, in points, of the rows relative to the anchor.
  /// </summary>
  public float VerticalPosition { get; set; }

  /// <summary>
  /// Reference used for horizontal positioning.
  /// </summary>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Reference used for vertical positioning.
  /// </summary>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Indicates whether floating tables are allowed to overlap.
  /// </summary>
  public int AllowOverlap { get; set; }

  /// <summary>
  /// The nesting level of the rows within nested tables.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// Reading order direction for table rows.
  /// </summary>
  public WdTableDirection TableDirection { get; set; }
}
