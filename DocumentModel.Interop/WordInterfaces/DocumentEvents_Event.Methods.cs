namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event?view=word-pia"/>
public partial interface IDocumentEvents_Event
{
  /// <summary>
  /// Subscribes a handler to the New event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the New event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_new?view=word-pia"/>
  public void add_New(DocumentEvents_NewEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the New event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the New event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.remove_new?view=word-pia"/>
  public void remove_New(DocumentEvents_NewEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Open event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Open event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_open?view=word-pia"/>
  public void add_Open(DocumentEvents_OpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Open event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Open event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.remove_open?view=word-pia"/>
  public void remove_Open(DocumentEvents_OpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Close event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Close event is raised.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.add_close?view=word-pia"/>
  public void add_Close(DocumentEvents_CloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Close event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Close event.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documentevents_event.remove_close?view=word-pia"/>
  public void remove_Close(DocumentEvents_CloseEventHandler param1);
}
