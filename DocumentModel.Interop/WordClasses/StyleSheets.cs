namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of StyleSheet objects that represents the cascading style sheets attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets?view=word-pia"/>
public partial class StyleSheets : InteropCollection<StyleSheet>
{


  #region methods

/// <summary>
  /// Adds a new style sheet to the collection.
  /// </summary>
  /// <param name="fileName">The file name of the style sheet to add.</param>
  /// <param name="linkType">The type of link for the style sheet.</param>
  /// <param name="title">The title of the style sheet.</param>
  /// <param name="precedence">The precedence of the style sheet.</param>
  /// <returns>The created <see cref="StyleSheet"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.stylesheets.add?view=word-pia"/>
  public StyleSheet Add(string fileName, StyleSheetLinkType linkType, string title, StyleSheetPrecedence precedence) { throw new NotImplementedException(); }

  #endregion methods
}
