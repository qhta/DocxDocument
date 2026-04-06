namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets?view=word-pia"/>
public partial interface IStyleSheets: IModelObject
{
  /// <summary>
  /// Adds a new style sheet to the collection.
  /// </summary>
  /// <param name="FileName">The file name of the style sheet to add.</param>
  /// <param name="LinkType">The type of link for the style sheet.</param>
  /// <param name="Title">The title of the style sheet.</param>
  /// <param name="Precedence">The precedence of the style sheet.</param>
  /// <returns>The created <see cref="IStyleSheet"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets.add?view=word-pia"/>
  public IStyleSheet Add(string FileName, StyleSheetLinkType LinkType, string Title, StyleSheetPrecedence Precedence);
}
