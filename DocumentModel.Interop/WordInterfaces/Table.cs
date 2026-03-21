namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table?view=word-pia"/>
public partial interface Table : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The columns.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.columns?view=word-pia"/>
  public Columns Columns { get; }

  /// <summary>
  /// The rows.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rows?view=word-pia"/>
  public Rows Rows { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The uniform.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.uniform?view=word-pia"/>
  public bool Uniform { get; }

  /// <summary>
  /// The auto format type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.autoformattype?view=word-pia"/>
  public int AutoFormatType { get; }

  /// <summary>
  /// The tables.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// The nesting level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.nestinglevel?view=word-pia"/>
  public int NestingLevel { get; }

  /// <summary>
  /// The allow page breaks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowpagebreaks?view=word-pia"/>
  public bool AllowPageBreaks { get; set; }

  /// <summary>
  /// The allow auto fit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.allowautofit?view=word-pia"/>
  public bool AllowAutoFit { get; set; }

  /// <summary>
  /// The preferred width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidth?view=word-pia"/>
  public float PreferredWidth { get; set; }

  /// <summary>
  /// The preferred width type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.preferredwidthtype?view=word-pia"/>
  public WdPreferredWidthType PreferredWidthType { get; set; }

  /// <summary>
  /// The top padding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }

  /// <summary>
  /// The bottom padding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }

  /// <summary>
  /// The left padding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }

  /// <summary>
  /// The right padding.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }

  /// <summary>
  /// The spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// The table direction.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.tabledirection?view=word-pia"/>
  public WdTableDirection TableDirection { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The apply style heading rows.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystyleheadingrows?view=word-pia"/>
  public bool ApplyStyleHeadingRows { get; set; }

  /// <summary>
  /// The apply style last row.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastrow?view=word-pia"/>
  public bool ApplyStyleLastRow { get; set; }

  /// <summary>
  /// The apply style first column.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylefirstcolumn?view=word-pia"/>
  public bool ApplyStyleFirstColumn { get; set; }

  /// <summary>
  /// The apply style last column.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylelastcolumn?view=word-pia"/>
  public bool ApplyStyleLastColumn { get; set; }

  /// <summary>
  /// The apply style row bands.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylerowbands?view=word-pia"/>
  public bool ApplyStyleRowBands { get; set; }

  /// <summary>
  /// The apply style column bands.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.applystylecolumnbands?view=word-pia"/>
  public bool ApplyStyleColumnBands { get; set; }

  /// <summary>
  /// The title.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.title?view=word-pia"/>
  public string Title { get; set; }

  /// <summary>
  /// The descr.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.table.descr?view=word-pia"/>
  public string Descr { get; set; }
}
