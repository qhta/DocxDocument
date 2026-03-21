namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single section in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section?view=word-pia"/>
public interface Section : InteropObject
{
  /// <summary>
  /// Returns the range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Returns or sets the page setup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }
  /// <summary>
  /// Returns the headers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.headers?view=word-pia"/>
  public HeadersFooters Headers { get; }
  /// <summary>
  /// Returns the footers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.footers?view=word-pia"/>
  public HeadersFooters Footers { get; }
  /// <summary>
  /// Returns or sets whether protected for forms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.protectedforforms?view=word-pia"/>
  public bool ProtectedForForms { get; set; }
  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Returns or sets the borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.borders?view=word-pia"/>
  public Borders Borders { get; set; }

}
