namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Style objects that represent both the built-in and user-defined styles in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles?view=word-pia"/>
public partial class Styles : InteropCollection<Style>
{


  #region methods

/// <summary>
  /// Adds a new style to the collection.
  /// </summary>
  /// <param name="Name">The name of the new style.</param>
  /// <param name="Type">The type of the new style.</param>
  /// <returns>The created <see cref="Style"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.styles.add?view=word-pia"/>
  public Style Add(string Name, StyleType Type) { throw new NotImplementedException(); }

  #endregion methods
}
