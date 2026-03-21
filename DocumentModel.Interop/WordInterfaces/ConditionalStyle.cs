namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents special formatting applied to specified areas of a table when the selected table is formatted with a specified table style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle?view=word-pia"/>
public interface ConditionalStyle : InteropObject
{
  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.shading?view=word-pia"/>
  public Shading Shading { get; }
  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.borders?view=word-pia"/>
  public Borders Borders { get; set; }
  /// <summary>
  /// The bottom padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }
  /// <summary>
  /// The top padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }
  /// <summary>
  /// The left padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }
  /// <summary>
  /// The right padding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }
  /// <summary>
  /// The paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.paragraphformat?view=word-pia"/>
  public ParagraphFormat ParagraphFormat { get; set; }
  /// <summary>
  /// The font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.font?view=word-pia"/>
  public Font Font { get; set; }

}
