namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the list of sources available attached to the document (in the current list) or the list of sources available in the application (in the master list).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography?view=word-pia"/>
public partial interface IBibliography : IModelObject
{
  /// <summary>
  /// Gets the collection of sources in the bibliography.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography.sources?view=word-pia"/>
  public ISources Sources { get; }

  /// <summary>
  /// Gets or sets the bibliography style name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.bibliography.bibliographystyle?view=word-pia"/>
  public string BibliographyStyle { get; set; }
}
