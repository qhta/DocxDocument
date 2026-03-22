namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol?view=word-pia"/>
public partial interface ContentControl
{
  /// <summary>
  /// Copies the content control from the active document to the Clipboard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.copy?view=word-pia"/>
  public void Copy();
}
