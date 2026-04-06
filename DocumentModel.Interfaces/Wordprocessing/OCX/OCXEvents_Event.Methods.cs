namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents_event?view=word-pia"/>
public partial interface IOCXEvents_Event
{
  /// <summary>
  /// A handler for the GotFocus event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents_event.add_gotfocus?view=word-pia"/>
  public event App.OCXEvents_GotFocusEventHandler GotFocus;


  /// <summary>
  /// A handler for the LostFocus event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.ocxevents_event.add_lostfocus?view=word-pia"/>
  public event App.OCXEvents_LostFocusEventHandler LostFocus;

}
