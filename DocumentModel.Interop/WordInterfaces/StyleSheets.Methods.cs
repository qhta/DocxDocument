namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets?view=word-pia"/>
public partial interface StyleSheets
{
  /// <summary>
  /// Adds a new style sheet to the collection.
  /// </summary>
  /// <param name="FileName">The file name of the style sheet to add.</param>
  /// <param name="LinkType">The type of link for the style sheet.</param>
  /// <param name="Title">The title of the style sheet.</param>
  /// <param name="Precedence">The precedence of the style sheet.</param>
  /// <returns>The created <see cref="StyleSheet"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets.add?view=word-pia"/>
  public StyleSheet Add(string FileName, WdStyleSheetLinkType LinkType, string Title, WdStyleSheetPrecedence Precedence);
}
