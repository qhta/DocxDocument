namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list of sources available attached to the document (in the current list) or the list of sources available in the application (in the master list).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography?view=word-pia"/>
public partial interface Bibliography : InteropObject
{
  /// <summary>
  /// The sources.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography.sources?view=word-pia"/>
  public Sources Sources { get; }

  /// <summary>
  /// The bibliography style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography.bibliographystyle?view=word-pia"/>
  public string BibliographyStyle { get; set; }
}
