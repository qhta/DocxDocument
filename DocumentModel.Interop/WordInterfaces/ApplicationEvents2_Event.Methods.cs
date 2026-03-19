namespace DocumentModel.Interop.Word;

public partial interface ApplicationEvents2_Event
{
  /// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Startup occurs.</param>
  public void add_Startup(ApplicationEvents2_StartupEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Startup notifications.</param>
  public void remove_Startup(ApplicationEvents2_StartupEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Quit occurs.</param>
  public void add_Quit(ApplicationEvents2_QuitEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Quit notifications.</param>
  public void remove_Quit(ApplicationEvents2_QuitEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when DocumentChange occurs.</param>
  public void add_DocumentChange(ApplicationEvents2_DocumentChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentChange notifications.</param>
  public void remove_DocumentChange(ApplicationEvents2_DocumentChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document is opened.</param>
  public void add_DocumentOpen(ApplicationEvents2_DocumentOpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentOpen notifications.</param>
  public void remove_DocumentOpen(ApplicationEvents2_DocumentOpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document closes.</param>
  public void add_DocumentBeforeClose(ApplicationEvents2_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeClose notifications.</param>
  public void remove_DocumentBeforeClose(ApplicationEvents2_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is printed.</param>
  public void add_DocumentBeforePrint(ApplicationEvents2_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforePrint notifications.</param>
  public void remove_DocumentBeforePrint(ApplicationEvents2_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is saved.</param>
  public void add_DocumentBeforeSave(ApplicationEvents2_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeSave notifications.</param>
  public void remove_DocumentBeforeSave(ApplicationEvents2_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a new document is created.</param>
  public void add_NewDocument(ApplicationEvents2_NewDocumentEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to remove from NewDocument notifications.</param>
  public void remove_NewDocument(ApplicationEvents2_NewDocumentEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is activated.</param>
  public void add_WindowActivate(ApplicationEvents2_WindowActivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowActivate notifications.</param>
  public void remove_WindowActivate(ApplicationEvents2_WindowActivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is deactivated.</param>
  public void add_WindowDeactivate(ApplicationEvents2_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowDeactivate notifications.</param>
  public void remove_WindowDeactivate(ApplicationEvents2_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the selection changes in a window.</param>
  public void add_WindowSelectionChange(ApplicationEvents2_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSelectionChange notifications.</param>
  public void remove_WindowSelectionChange(ApplicationEvents2_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a right-click action in a window.</param>
  public void add_WindowBeforeRightClick(ApplicationEvents2_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeRightClick notifications.</param>
  public void remove_WindowBeforeRightClick(ApplicationEvents2_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a double-click action in a window.</param>
  public void add_WindowBeforeDoubleClick(ApplicationEvents2_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeDoubleClick notifications.</param>
  public void remove_WindowBeforeDoubleClick(ApplicationEvents2_WindowBeforeDoubleClickEventHandler param1);
}
