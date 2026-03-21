namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision?view=word-pia"/>
public partial interface Revision
{
  /// <summary>
  /// Accepts the specified tracked change. The revision marks are removed, and the change is incorporated into the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revision.accept?view=word-pia"/>
  public void Accept();
}
