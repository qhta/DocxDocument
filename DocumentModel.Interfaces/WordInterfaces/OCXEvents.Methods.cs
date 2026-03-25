namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents?view=word-pia"/>
public partial interface OCXEvents: InteropObject
{
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents.gotfocus?view=word-pia"/>
  public void GotFocus();

  /// <summary>
  /// Handles the LostFocus event for the OCX control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents.lostfocus?view=word-pia"/>
  public void LostFocus();
}
