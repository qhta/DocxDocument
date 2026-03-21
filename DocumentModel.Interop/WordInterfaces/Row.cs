namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a row in a table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row?view=word-pia"/>
public partial interface Row : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The allow break across pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.allowbreakacrosspages?view=word-pia"/>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.alignment?view=word-pia"/>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// The heading format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.headingformat?view=word-pia"/>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// The space between columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.spacebetweencolumns?view=word-pia"/>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// The height rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.heightrule?view=word-pia"/>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The is last.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.islast?view=word-pia"/>
  public bool IsLast { get; }

  /// <summary>
  /// The is first.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.isfirst?view=word-pia"/>
  public bool IsFirst { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The cells.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.cells?view=word-pia"/>
  public Cells Cells { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.next?view=word-pia"/>
  public Row Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.previous?view=word-pia"/>
  public Row Previous { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.id?view=word-pia"/>
  public string ID { get; set; }
}
