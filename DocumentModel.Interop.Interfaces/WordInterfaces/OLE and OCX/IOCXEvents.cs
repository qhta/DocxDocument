namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents OLE control event handlers for Word ActiveX controls.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents?view=word-pia"/>
public interface IOCXEvents
{	

  #region methods	
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
  #endregion methods
}
