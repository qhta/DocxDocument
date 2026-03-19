namespace DocumentModel.Interop.Word;

public partial interface Windows
{
  /// <summary>
  /// Adds a new window to the collection.
  /// </summary>
  /// <param name="Window">The window to add to the collection.</param>
  /// <returns>The created <see cref="Window"/> object.</returns>
  public Window Add(object Window);
}
