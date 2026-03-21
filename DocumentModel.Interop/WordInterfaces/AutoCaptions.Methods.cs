namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaptions?view=word-pia"/>
public partial interface AutoCaptions
{
  /// <summary>
  /// Cancels automatic caption insertion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaptions.cancelautoinsert?view=word-pia"/>
  public void CancelAutoInsert();
}
