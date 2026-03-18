namespace DocumentModel.Interop;

/// <summary>
/// Represents a single table.
/// </summary>
public partial interface Table : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The columns.
  /// </summary>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  public Rows Rows { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The uniform.
  /// </summary>
  public bool Uniform { get; }

  /// <summary>
  /// The auto format type.
  /// </summary>
  public int AutoFormatType { get; }

  /// <summary>
  /// The tables.
  /// </summary>
  public Tables Tables { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }

  /// <summary>
  /// The allow page breaks.
  /// </summary>
  public bool AllowPageBreaks { get; set; }

  /// <summary>
  /// The allow auto fit.
  /// </summary>
  public bool AllowAutoFit { get; set; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  public WdPreferredWidthType PreferredWidthType { get; set; }

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
  /// The spacing.
  /// </summary>
  public float Spacing { get; set; }

  /// <summary>
  /// The table direction.
  /// </summary>
  public WdTableDirection TableDirection { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

  /// <summary>
  /// The apply style heading rows.
  /// </summary>
  public bool ApplyStyleHeadingRows { get; set; }

  /// <summary>
  /// The apply style last row.
  /// </summary>
  public bool ApplyStyleLastRow { get; set; }

  /// <summary>
  /// The apply style first column.
  /// </summary>
  public bool ApplyStyleFirstColumn { get; set; }

  /// <summary>
  /// The apply style last column.
  /// </summary>
  public bool ApplyStyleLastColumn { get; set; }

  /// <summary>
  /// The apply style row bands.
  /// </summary>
  public bool ApplyStyleRowBands { get; set; }

  /// <summary>
  /// The apply style column bands.
  /// </summary>
  public bool ApplyStyleColumnBands { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  public string Title { get; set; }

  /// <summary>
  /// The descr.
  /// </summary>
  public string Descr { get; set; }
}
