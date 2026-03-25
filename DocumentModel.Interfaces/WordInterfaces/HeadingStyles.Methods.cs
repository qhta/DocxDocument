namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.headingstyles?view=word-pia"/>
public partial interface HeadingStyles: InteropObject
{
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
  public HeadingStyle Add(object Style, short Level);
}
