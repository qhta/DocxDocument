namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table column. The Column object is a member of the Columns collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column?view=word-pia"/>
public interface IColumn : IInteropObject
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
  public bool IsFirst { get; }

  /// <summary>
  /// Gets a value indicating whether the column is the last column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.islast?view=word-pia"/>
  public bool IsLast { get; }

  /// <summary>
  /// Gets the index number of the column in the `Columns` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets the collection of cells in the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.cells?view=word-pia"/>
  public ICells Cells { get; }

  /// <summary>
  /// Gets or sets the border formatting for the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.borders?view=word-pia"/>
  public IBorders Borders { get; set; }

  /// <summary>
  /// Gets the shading formatting for the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.shading?view=word-pia"/>
  public IShading Shading { get; }

  /// <summary>
  /// Gets the next column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.next?view=word-pia"/>
  public IColumn Next { get; }

  /// <summary>
  /// Gets the previous column in the table.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.previous?view=word-pia"/>
  public IColumn Previous { get; }

  /// <summary>
  /// Gets the nesting level of the column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

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


  #region methods

/// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.column.select?view=word-pia"/>
  public void Select();

  #endregion methods
}
