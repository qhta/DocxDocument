namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single HTML division that can be added to a Web document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision?view=word-pia"/>
public partial interface HTMLDivision : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.borders?view=word-pia"/>
  public Borders Borders { get; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The right indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// The space before.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// The space after.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// The htmldivisions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.htmldivision.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }
}
