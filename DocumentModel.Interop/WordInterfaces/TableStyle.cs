namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single style that can be applied to a table.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle?view=word-pia"/>
public partial interface TableStyle : InteropObject
{
  /// <summary>
  /// The allow page breaks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.allowpagebreaks?view=word-pia"/>
  public bool AllowPageBreaks { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The bottom padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }

  /// <summary>
  /// The left padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }

  /// <summary>
  /// The top padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }

  /// <summary>
  /// The right padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.alignment?view=word-pia"/>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// The spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// The table direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.tabledirection?view=word-pia"/>
  public WdTableDirection TableDirection { get; set; }

  /// <summary>
  /// The allow break across page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.allowbreakacrosspage?view=word-pia"/>
  public int AllowBreakAcrossPage { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The row stripe.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.rowstripe?view=word-pia"/>
  public int RowStripe { get; set; }

  /// <summary>
  /// The column stripe.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tablestyle.columnstripe?view=word-pia"/>
  public int ColumnStripe { get; set; }
}
