namespace DocumentModel.Interop.Word;

public partial interface OCXEvents_Event
{
  /// <summary>
  /// Subscribes a handler to the GotFocus event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the GotFocus event is raised.</param>
  public void add_GotFocus(OCXEvents_GotFocusEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the GotFocus event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the GotFocus event.</param>
  public void remove_GotFocus(OCXEvents_GotFocusEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the LostFocus event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the LostFocus event is raised.</param>
  public void add_LostFocus(OCXEvents_LostFocusEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the LostFocus event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the LostFocus event.</param>
  public void remove_LostFocus(OCXEvents_LostFocusEventHandler param1);
}
