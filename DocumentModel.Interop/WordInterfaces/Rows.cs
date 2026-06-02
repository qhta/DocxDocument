namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Row objects that represent the table rows in the specified selection, range, or table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows?view=word-pia"/>
public partial interface IRows : IInteropObject, IInteropCollection<Row>
{
  /// <summary>
  /// Determine if the text in a table row or rows is allowed to split across a page break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowbreakacrosspages?view=word-pia"/>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// Returns or sets a RowAlignment constant that represents the alignment for the specified rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.alignment?view=word-pia"/>
  public RowAlignment Alignment { get; set; }

  /// <summary>
  /// Determine if the specified row or rows are formatted as a table heading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.headingformat?view=word-pia"/>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between text in adjacent columns of the specified row or rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.spacebetweencolumns?view=word-pia"/>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// Returns or sets the height of the specified row or rows in a table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns or sets the rule for determining the height of the specified rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.heightrule?view=word-pia"/>
  public RowHeightRule HeightRule { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified table rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Returns a Row object that represents the first item in the Rows collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.first?view=word-pia"/>
  public Row First { get; }

  /// <summary>
  /// Returns the last item in the Rows collection as a Row object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.last?view=word-pia"/>
  public Row Last { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Determines whether text should wrap around the specified rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.wraparoundtext?view=word-pia"/>
  public int WrapAroundText { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the top edge of the specified table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancetop?view=word-pia"/>
  public float DistanceTop { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the bottom edge of the specified table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distancebottom?view=word-pia"/>
  public float DistanceBottom { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the left edge of the specified table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceleft?view=word-pia"/>
  public float DistanceLeft { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between the document text and the right edge of the specified table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.distanceright?view=word-pia"/>
  public float DistanceRight { get; set; }

  /// <summary>
  /// Returns or sets the horizontal distance between the edge of the rows and the item specified by the
  /// RelativeHorizontalPosition property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.horizontalposition?view=word-pia"/>
  public float HorizontalPosition { get; set; }

  /// <summary>
  /// Returns or sets the vertical distance between the edge of the rows and the item specified by the
  /// RelativeVerticalPosition property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.verticalposition?view=word-pia"/>
  public float VerticalPosition { get; set; }

  /// <summary>
  /// Specifies to what the horizontal position of a group of rows is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativehorizontalposition?view=word-pia"/>
  public RelativeHorizontalPosition RelativeHorizontalPosition { get; set; }

  /// <summary>
  /// Specifies to what the vertical position of a group of rows is relative.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.relativeverticalposition?view=word-pia"/>
  public RelativeVerticalPosition RelativeVerticalPosition { get; set; }

  /// <summary>
  /// Returns or sets a value that specifies whether the specified rows can overlap other rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.allowoverlap?view=word-pia"/>
  public int AllowOverlap { get; set; }

  /// <summary>
  /// Returns the nesting level of the specified rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Returns or sets the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.rows.tabledirection?view=word-pia"/>
  public TableDirection TableDirection { get; set; }
}
