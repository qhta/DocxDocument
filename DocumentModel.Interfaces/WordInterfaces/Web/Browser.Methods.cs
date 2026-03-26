namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser?view=word-pia"/>
public partial interface Browser: InteropObject
{
  /// <summary>
  /// Moves the selection to the next item indicated by the browser target.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.next?view=word-pia"/>
  public void Next();
}
