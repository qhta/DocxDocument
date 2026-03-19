namespace DocumentModel.Interop.Word;

public partial interface HeadingStyles
{
  /// <summary>
  /// Adds a heading style mapping to the collection.
  /// </summary>
  /// <param name="Style">The style to map to a heading level.</param>
  /// <param name="Level">The heading level associated with the style.</param>
  /// <returns>The created <see cref="HeadingStyle"/> object.</returns>
  public HeadingStyle Add(object Style, short Level);
}
