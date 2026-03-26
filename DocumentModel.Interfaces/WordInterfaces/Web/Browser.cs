namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the browser tool used to move the insertion point to objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser?view=word-pia"/>
public partial interface Browser : InteropObject
{
  /// <summary>
  /// Gets or sets the type of item that the browser moves to.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.target?view=word-pia"/>
  public BrowseTarget Target { get; set; }
}
