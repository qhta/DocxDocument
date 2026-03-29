namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Column objects that represent the columns in a table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns?view=word-pia"/>
public partial interface Columns : InteropCollection<Column>
{
  /// <summary>
  /// Gets the first column in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.first?view=word-pia"/>
  public Column First { get; }

  /// <summary>
  /// Gets the last column in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.last?view=word-pia"/>
  public Column Last { get; }

  /// <summary>
  /// Gets or sets the width of all columns in the collection, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Gets the shading formatting for the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.shading?view=word-pia"/>
  public Drw.Shading Shading { get; }

  /// <summary>
  /// Gets the nesting level of the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Gets or sets the preferred width of the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// Gets or sets the preferred width type for the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.columns.preferredwidthtype?view=word-pia"/>
  public PreferredWidthType PreferredWidthType { get; set; }
}
