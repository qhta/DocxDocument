namespace DocumentModel.Interop.Word;

public partial interface Styles
{
  /// <summary>
  /// Adds a new style to the collection.
  /// </summary>
  /// <param name="Name">The name of the new style.</param>
  /// <param name="Type">The type of the new style.</param>
  /// <returns>The created <see cref="Style"/> object.</returns>
  public Style Add(string Name, WdStyleType Type);
}
