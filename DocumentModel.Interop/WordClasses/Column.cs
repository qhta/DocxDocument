namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table column. The Column object is a member of the Columns collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column?view=word-pia"/>
public partial class Column : InteropObject
{
  /// <summary>
  /// Gets or sets the width of the column, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Gets a value indicating whether the column is the first column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.isfirst?view=word-pia"/>
  public bool IsFirst { get; set; }

  /// <summary>
  /// Gets a value indicating whether the column is the last column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.islast?view=word-pia"/>
  public bool IsLast { get; set; }

  /// <summary>
  /// Gets the index number of the column in the `Columns` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Gets the collection of cells in the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.cells?view=word-pia"/>
  public Cells Cells { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Gets the shading formatting for the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.shading?view=word-pia"/>
  public Shading Shading { get; set; }

  /// <summary>
  /// Gets the next column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.next?view=word-pia"/>
  public Column Next { get; set; }

  /// <summary>
  /// Gets the previous column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.previous?view=word-pia"/>
  public Column Previous { get; set; }

  /// <summary>
  /// Gets the nesting level of the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; set; }

  /// <summary>
  /// Gets or sets the preferred width of the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// Gets or sets the preferred width type for the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.preferredwidthtype?view=word-pia"/>
  public PreferredWidthType PreferredWidthType { get; set; }
}
