namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table?view=word-pia"/>
public partial interface Table : InteropObject
{
  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns the columns.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// Returns the rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// Returns or sets the borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns the shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Returns whether uniform.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.uniform?view=word-pia"/>
  public bool Uniform { get; }

  /// <summary>
  /// Returns the auto format type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.autoformattype?view=word-pia"/>
  public int AutoFormatType { get; }

  /// <summary>
  /// Returns the tables.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// Returns the nesting level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// Returns or sets whether allow page breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowpagebreaks?view=word-pia"/>
  public bool AllowPageBreaks { get; set; }

  /// <summary>
  /// Returns or sets whether allow auto fit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowautofit?view=word-pia"/>
  public bool AllowAutoFit { get; set; }

  /// <summary>
  /// Returns or sets the preferred width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// Returns or sets the preferred width type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidthtype?view=word-pia"/>
  public WdPreferredWidthType PreferredWidthType { get; set; }

  /// <summary>
  /// Returns or sets the top padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }

  /// <summary>
  /// Returns or sets the bottom padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }

  /// <summary>
  /// Returns or sets the left padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }

  /// <summary>
  /// Returns or sets the right padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }

  /// <summary>
  /// Returns or sets the spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// Returns or sets the table direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tabledirection?view=word-pia"/>
  public WdTableDirection TableDirection { get; set; }

  /// <summary>
  /// Returns or sets the i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// Returns or sets the style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns or sets whether apply style heading rows.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystyleheadingrows?view=word-pia"/>
  public bool ApplyStyleHeadingRows { get; set; }

  /// <summary>
  /// Returns or sets whether apply style last row.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastrow?view=word-pia"/>
  public bool ApplyStyleLastRow { get; set; }

  /// <summary>
  /// Returns or sets whether apply style first column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylefirstcolumn?view=word-pia"/>
  public bool ApplyStyleFirstColumn { get; set; }

  /// <summary>
  /// Returns or sets whether apply style last column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastcolumn?view=word-pia"/>
  public bool ApplyStyleLastColumn { get; set; }

  /// <summary>
  /// Returns or sets whether apply style row bands.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylerowbands?view=word-pia"/>
  public bool ApplyStyleRowBands { get; set; }

  /// <summary>
  /// Returns or sets whether apply style column bands.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylecolumnbands?view=word-pia"/>
  public bool ApplyStyleColumnBands { get; set; }

  /// <summary>
  /// Returns or sets the title.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// Returns or sets the descr.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.descr?view=word-pia"/>
  public string Descr { get; set; }
}
