namespace DocumentModel.Interop;

public partial interface DocumentEvents_Event
{
  /// <summary>
  /// Subscribes a handler to the New event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the New event is raised.</param>
  public void add_New(DocumentEvents_NewEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the New event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the New event.</param>
  public void remove_New(DocumentEvents_NewEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Open event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Open event is raised.</param>
  public void add_Open(DocumentEvents_OpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Open event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Open event.</param>
  public void remove_Open(DocumentEvents_OpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Close event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Close event is raised.</param>
  public void add_Close(DocumentEvents_CloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Close event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Close event.</param>
  public void remove_Close(DocumentEvents_CloseEventHandler param1);
}
