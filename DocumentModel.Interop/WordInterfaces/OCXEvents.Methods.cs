namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents?view=word-pia"/>
public partial interface OCXEvents
{
  /// <summary>
  /// Occurs when the OCX control receives focus.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents.gotfocus?view=word-pia"/>
  public void GotFocus();

  /// <summary>
  /// Occurs when the OCX control loses focus.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents.lostfocus?view=word-pia"/>
  public void LostFocus();
}
