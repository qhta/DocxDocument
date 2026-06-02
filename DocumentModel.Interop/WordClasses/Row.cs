namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a row in a table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row?view=word-pia"/>
public partial class Row : InteropObject
{
  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Determines if the text in a table row or rows are allowed to split across a page break.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.allowbreakacrosspages?view=word-pia"/>
  public int AllowBreakAcrossPages { get; set; }

  /// <summary>
  /// Returns or sets a RowAlignment constant that represents the alignment for the specified rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.alignment?view=word-pia"/>
  public RowAlignment Alignment { get; set; }

  /// <summary>
  /// Determines if the specified row or rows are formatted as a table heading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.headingformat?view=word-pia"/>
  public int HeadingFormat { get; set; }

  /// <summary>
  /// Returns or sets the distance (in points) between text in adjacent columns of the specified row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.spacebetweencolumns?view=word-pia"/>
  public float SpaceBetweenColumns { get; set; }

  /// <summary>
  /// Returns or sets the height of the specified row in a table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.height?view=word-pia"/>
  public float Height { get; set; }

  /// <summary>
  /// Returns or sets the rule for determining the height of the specified row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.heightrule?view=word-pia"/>
  public RowHeightRule HeightRule { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified table row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Determines if the specified column or row is the last one in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.islast?view=word-pia"/>
  public bool IsLast { get; set; }

  /// <summary>
  /// Determines if the specified column or row is the first one in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.isfirst?view=word-pia"/>
  public bool IsFirst { get; set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns a Cells collection that represents the table cells in a column, row, selection, or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.cells?view=word-pia"/>
  public Cells Cells { get; set; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.shading?view=word-pia"/>
  public Shading Shading { get; set; }

  /// <summary>
  /// Returns the next object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.next?view=word-pia"/>
  public Row Next { get; set; }

  /// <summary>
  /// Returns the previous object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.previous?view=word-pia"/>
  public Row Previous { get; set; }

  /// <summary>
  /// Returns the nesting level of the specified row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; set; }

  /// <summary>
  /// Returns or sets the identifying label for the specified object when the current document is saved as a Web
  /// page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.id?view=word-pia"/>
  public string? ID { get; set; }


  #region methods

/// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.row.select?view=word-pia"/>
  public void Select() { throw new NotImplementedException(); }

  #endregion methods
}
