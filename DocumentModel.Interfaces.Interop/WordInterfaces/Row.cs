namespace DocumentModel.Interop;

/// <summary>
/// Represents a row in a table.
/// </summary>
public partial interface Row : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The allow break across pages.
  /// </summary>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// The heading format.
  /// </summary>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// The space between columns.
  /// </summary>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The is last.
  /// </summary>
  public bool IsLast { get; }

  /// <summary>
  /// The is first.
  /// </summary>
  public bool IsFirst { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  public Cells Cells { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public Row Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Row Previous { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; set; }
}
