namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single table.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table?view=word-pia"/>
public partial interface ITable : IModelObject
{
  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns a Columns collection that represents all the table columns in the table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.columns?view=word-pia"/>
  public IColumns Columns { get; }

  /// <summary>
  /// Returns a Rows collection that represents all the table rows in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rows?view=word-pia"/>
  public IRows Rows { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// True if all the rows in a table have the same number of columns.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.uniform?view=word-pia"/>
  public bool Uniform { get; }

  /// <summary>
  /// Returns the type of automatic formatting that's been applied to the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.autoformattype?view=word-pia"/>
  public int AutoFormatType { get; }

  /// <summary>
  /// Returns a Tables collection that represents all the tables in the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tables?view=word-pia"/>
  public ITables Tables { get; }

  /// <summary>
  /// Returns the nesting level of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Allows Microsoft Word to break the specified table across pages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowpagebreaks?view=word-pia"/>
  public bool AllowPageBreaks { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Allows Microsoft Word to automatically resize cells in a table to fit their contents.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowautofit?view=word-pia"/>
  public bool AllowAutoFit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the preferred width (in points or as a percentage of the window width) for the specified cell,
  /// cells, columns, or table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidth?view=word-pia"/>
  public float PreferredWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the preferred unit of measurement to use for the width of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidthtype?view=word-pia"/>
  public PreferredWidthType PreferredWidthType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add above the contents of a single cell or all the cells in
  /// a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.toppadding?view=word-pia"/>
  public float TopPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add below the contents of a single cell or all the cells in
  /// a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.bottompadding?view=word-pia"/>
  public float BottomPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add to the left of the contents of a single cell or all the
  /// cells in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.leftpadding?view=word-pia"/>
  public float LeftPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of space (in points) to add to the right of the contents of a single cell or all
  /// the cells in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rightpadding?view=word-pia"/>
  public float RightPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the spacing (in points) between the cells in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.spacing?view=word-pia"/>
  public float Spacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the direction in which Microsoft Word orders cells in the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tabledirection?view=word-pia"/>
  public TableDirection TableDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the identifying label for the specified object when the current document is saved as a Web
  /// page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.id?view=word-pia"/>
  public string ID { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.style?view=word-pia"/>
  public object Style { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to apply heading-row formatting to the first row of the selected table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystyleheadingrows?view=word-pia"/>
  public bool ApplyStyleHeadingRows { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to apply last-row formatting to the last row of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastrow?view=word-pia"/>
  public bool ApplyStyleLastRow { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to apply first-column formatting to the first column of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylefirstcolumn?view=word-pia"/>
  public bool ApplyStyleFirstColumn { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True for Microsoft Word to apply last-column formatting to the last column of the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastcolumn?view=word-pia"/>
  public bool ApplyStyleLastColumn { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to apply style bands to the rows in a table if an applied
  /// preset table style provides style banding for rows. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylerowbands?view=word-pia"/>
  public bool ApplyStyleRowBands { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to apply style bands to the columns in a table if an applied
  /// preset table style provides style banding for columns. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylecolumnbands?view=word-pia"/>
  public bool ApplyStyleColumnBands { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a string that contains a title for the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.title?view=word-pia"/>
  public string Title { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a string that contains a description for the specified table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.descr?view=word-pia"/>
  public string Descr { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
