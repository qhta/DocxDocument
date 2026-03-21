namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single section in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section?view=word-pia"/>
public interface Section : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// The page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }
  /// <summary>
  /// The headers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.headers?view=word-pia"/>
  public HeadersFooters Headers { get; }
  /// <summary>
  /// The footers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.footers?view=word-pia"/>
  public HeadersFooters Footers { get; }
  /// <summary>
  /// The protected for forms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.protectedforforms?view=word-pia"/>
  public bool ProtectedForForms { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.borders?view=word-pia"/>
  public Borders Borders { get; set; }

}
