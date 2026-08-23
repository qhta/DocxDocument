namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Cell objects in a table column, table row, selection, or range.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells?view=word-pia"/>
public partial interface ICells : IModelCollection<ICell>
{
  /// <summary>
  /// Gets or sets the width of the cells, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.width?view=word-pia"/>
  public float Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the height of the cells, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.height?view=word-pia"/>
  public float Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the rule for determining row height.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.heightrule?view=word-pia"/>
  public RowHeightRule HeightRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the vertical alignment of text in the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.verticalalignment?view=word-pia"/>
  public TableVerticalAlignment VerticalAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the border formatting for the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets the shading formatting for the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Gets the nesting level of the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Gets or sets the preferred width of the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.preferredwidth?view=word-pia"/>
  public float PreferredWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the preferred width type for the cells.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.cells.preferredwidthtype?view=word-pia"/>
  public PreferredWidthType PreferredWidthType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
