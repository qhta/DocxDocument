namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event?view=word-pia"/>
public partial interface DocumentEvents_Event
{
  /// <summary>
  /// A handler to the New event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_new?view=word-pia"/>
  public event App.DocumentEvents_NewEventHandler New;

  /// <summary>
  /// A handler to the Open event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_open?view=word-pia"/>
  public event App.DocumentEvents_OpenEventHandler Open;

  /// <summary>
  /// A handler to the Close event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_close?view=word-pia"/>
  public event App.DocumentEvents_CloseEventHandler Close;

}
