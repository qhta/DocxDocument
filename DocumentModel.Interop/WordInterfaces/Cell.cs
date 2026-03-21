namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table cell.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell?view=word-pia"/>
public partial interface Cell : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The row index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.rowindex?view=word-pia"/>
  public int RowIndex { get; }

  /// <summary>
  /// The column index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.columnindex?view=word-pia"/>
  public int ColumnIndex { get; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.heightrule?view=word-pia"/>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The vertical alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.verticalalignment?view=word-pia"/>
  public WdCellVerticalAlignment VerticalAlignment { get; set; }

  /// <summary>
  /// The column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.column?view=word-pia"/>
  public Column Column { get; }

  /// <summary>
  /// The row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.row?view=word-pia"/>
  public Row Row { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.next?view=word-pia"/>
  public Cell Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.previous?view=word-pia"/>
  public Cell Previous { get; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.wordwrap?view=word-pia"/>
  public bool WordWrap { get; set; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The fit text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.fittext?view=word-pia"/>
  public bool FitText { get; set; }

  /// <summary>
  /// The top padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }

  /// <summary>
  /// The bottom padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }

  /// <summary>
  /// The left padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }

  /// <summary>
  /// The right padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cell.preferredwidthtype?view=word-pia"/>
  public WdPreferredWidthType PreferredWidthType { get; set; }
}
