namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape?view=word-pia"/>
public partial interface InlineShape: InteropObject
{
  /// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshape.activate?view=word-pia"/>
  public void Activate();
}
