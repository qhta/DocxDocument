namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Row objects that represent the table rows in the specified selection, range, or table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows?view=word-pia"/>
public partial interface Rows : InteropObject, InteropCollection<Row>
{
  /// <summary>
  /// Indicates whether text in the row is allowed to split across page breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowbreakacrosspages?view=word-pia"/>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// Alignment of rows in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.alignment?view=word-pia"/>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// Indicates whether the row is formatted as a heading row that repeats on subsequent pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.headingformat?view=word-pia"/>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// Returns or sets the space between columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.spacebetweencolumns?view=word-pia"/>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// Height, in points, for the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// How row height is interpreted (automatic, at least, or exactly).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.heightrule?view=word-pia"/>
  public WdRowHeightRule HeightRule { get; set; }

  /// <summary>
  /// Left indent, in points, applied to the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Returns the first.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.first?view=word-pia"/>
  public Row First { get; }

  /// <summary>
  /// Returns the last.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.last?view=word-pia"/>
  public Row Last { get; }

  /// <summary>
  /// Border formatting for the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns the shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Indicates whether text can wrap around the table rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.wraparoundtext?view=word-pia"/>
  public int WrapAroundText { get; set; }

  /// <summary>
  /// Top distance, in points, between surrounding text and the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancetop?view=word-pia"/>
  public float DistanceTop { get; set; }

  /// <summary>
  /// Bottom distance, in points, between surrounding text and the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancebottom?view=word-pia"/>
  public float DistanceBottom { get; set; }

  /// <summary>
  /// Left distance, in points, between surrounding text and the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceleft?view=word-pia"/>
  public float DistanceLeft { get; set; }

  /// <summary>
  /// Right distance, in points, between surrounding text and the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceright?view=word-pia"/>
  public float DistanceRight { get; set; }

  /// <summary>
  /// Horizontal position, in points, of the rows relative to the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.horizontalposition?view=word-pia"/>
  public float HorizontalPosition { get; set; }

  /// <summary>
  /// Vertical position, in points, of the rows relative to the anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.verticalposition?view=word-pia"/>
  public float VerticalPosition { get; set; }

  /// <summary>
  /// Reference used for horizontal positioning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativehorizontalposition?view=word-pia"/>
  public WdRelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Reference used for vertical positioning.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativeverticalposition?view=word-pia"/>
  public WdRelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Indicates whether floating tables are allowed to overlap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowoverlap?view=word-pia"/>
  public int AllowOverlap { get; set; }

  /// <summary>
  /// Returns the nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Reading order direction for table rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.tabledirection?view=word-pia"/>
  public WdTableDirection TableDirection { get; set; }
}
