namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows?view=word-pia"/>
public partial interface Windows: InteropObject
{
  /// <summary>
  /// Adds a new window to the collection.
  /// </summary>
  /// <param name="Window">The window to add to the collection.</param>
  /// <returns>The created <see cref="Window"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.add?view=word-pia"/>
  public Window Add(object Window);
}
