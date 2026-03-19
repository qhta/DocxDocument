namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the list of sources available attached to the document (in the current list) or the list of sources available in the application (in the master list).
/// </summary>
public partial interface Bibliography : InteropObject
{
  /// <summary>
  /// The sources.
  /// </summary>
  public Sources Sources { get; }

  /// <summary>
  /// The bibliography style.
  /// </summary>
  public string BibliographyStyle { get; set; }
}
