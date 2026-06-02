namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of HeadingStyle objects that represent the styles used to compile a table of figures or table of contents.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyles?view=word-pia"/>
public partial class HeadingStyles : InteropCollection<HeadingStyle>
{


  #region methods

/// <summary>
  /// Adds a heading style mapping to the collection.
  /// </summary>
  /// <param name="Style">The style to map to a heading level.</param>
  /// <param name="Level">The heading level associated with the style.</param>
  /// <returns>The created <see cref="HeadingStyle"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyles.add?view=word-pia"/>
  public HeadingStyle Add(object Style, short Level) { throw new NotImplementedException(); }

  #endregion methods
}
