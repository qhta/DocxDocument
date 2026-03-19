namespace DocumentModel.Interop.Word;

public partial interface XMLNodes
{
  /// <summary>
  /// Adds a new XML node to the collection.
  /// </summary>
  /// <param name="Name">The name of the XML node to add.</param>
  /// <param name="Namespace">The namespace of the XML node.</param>
  /// <param name="Range">The range where the XML node is inserted.</param>
  /// <returns>The created <see cref="XMLNode"/> object.</returns>
  public XMLNode Add(string Name, string Namespace, object Range);
}
