namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single style that can be applied to a table.
/// </summary>
public partial interface TableStyle : InteropObject
{
  /// <summary>
  /// The allow page breaks.
  /// </summary>
  public bool AllowPageBreaks { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  public Borders Borders { get; set; }

  /// <summary>
  /// The bottom padding.
  /// </summary>
  public float BottomPadding { get; set; }

  /// <summary>
  /// The left padding.
  /// </summary>
  public float LeftPadding { get; set; }

  /// <summary>
  /// The top padding.
  /// </summary>
  public float TopPadding { get; set; }

  /// <summary>
  /// The right padding.
  /// </summary>
  public float RightPadding { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  public WdRowAlignment Alignment { get; set; }

  /// <summary>
  /// The spacing.
  /// </summary>
  public float Spacing { get; set; }

  /// <summary>
  /// The table direction.
  /// </summary>
  public WdTableDirection TableDirection { get; set; }

  /// <summary>
  /// The allow break across page.
  /// </summary>
  public int AllowBreakAcrossPage { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  public Shading Shading { get; }

  /// <summary>
  /// The row stripe.
  /// </summary>
  public int RowStripe { get; set; }

  /// <summary>
  /// The column stripe.
  /// </summary>
  public int ColumnStripe { get; set; }
}
