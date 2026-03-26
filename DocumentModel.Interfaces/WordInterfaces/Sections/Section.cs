namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single section in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section?view=word-pia"/>
public interface Section : InteropObject
{
  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.range?view=word-pia"/>
  public Range Range { get; }
  /// <summary>
  /// Returns a PageSetup object that's associated with the specified section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }
  /// <summary>
  /// Returns a HeadersFooters collection that represents the headers for the specified section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.headers?view=word-pia"/>
  public HeadersFooters Headers { get; }
  /// <summary>
  /// Returns a HeadersFooters collection that represents the footers in the specified section.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.footers?view=word-pia"/>
  public HeadersFooters Footers { get; }
  /// <summary>
  /// True if the specified section is protected for forms. When a section is protected for forms, you can select
  /// and modify text only in form fields.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.protectedforforms?view=word-pia"/>
  public bool ProtectedForForms { get; set; }
  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.index?view=word-pia"/>
  public int Index { get; }
  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.section.borders?view=word-pia"/>
  public Borders Borders { get; set; }

}
