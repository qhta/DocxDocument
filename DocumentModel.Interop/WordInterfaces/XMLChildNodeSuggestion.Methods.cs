namespace DocumentModel.Interop;

public partial interface XMLChildNodeSuggestion
{
  /// <summary>
  /// Inserts a new XML child node at the specified range.
  /// </summary>
  /// <param name="Range">The range where the child node is inserted.</param>
  /// <returns>The created <see cref="XMLNode"/> object.</returns>
  public XMLNode Insert(object Range);
}
