namespace DocumentModel.Interop.Word;

/// <summary>
/// Events class for Microsoft Word 2000 Application object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event?view=word-pia"/>
public partial class ApplicationEvents2_Event
{


  #region methods

/// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Startup occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_startup?view=word-pia"/>
  public void add_Startup(ApplicationEvents2_StartupEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Startup notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_startup?view=word-pia"/>
  public void remove_Startup(ApplicationEvents2_StartupEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Quit occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_quit?view=word-pia"/>
  public void add_Quit(ApplicationEvents2_QuitEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Quit notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_quit?view=word-pia"/>
  public void remove_Quit(ApplicationEvents2_QuitEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when DocumentChange occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentchange?view=word-pia"/>
  public void add_DocumentChange(ApplicationEvents2_DocumentChangeEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentChange notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_documentchange?view=word-pia"/>
  public void remove_DocumentChange(ApplicationEvents2_DocumentChangeEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document is opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentopen?view=word-pia"/>
  public void add_DocumentOpen(ApplicationEvents2_DocumentOpenEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentOpen notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_documentopen?view=word-pia"/>
  public void remove_DocumentOpen(ApplicationEvents2_DocumentOpenEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document closes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforeclose?view=word-pia"/>
  public void add_DocumentBeforeClose(ApplicationEvents2_DocumentBeforeCloseEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeClose notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_documentbeforeclose?view=word-pia"/>
  public void remove_DocumentBeforeClose(ApplicationEvents2_DocumentBeforeCloseEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is printed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforeprint?view=word-pia"/>
  public void add_DocumentBeforePrint(ApplicationEvents2_DocumentBeforePrintEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforePrint notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_documentbeforeprint?view=word-pia"/>
  public void remove_DocumentBeforePrint(ApplicationEvents2_DocumentBeforePrintEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is saved.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforesave?view=word-pia"/>
  public void add_DocumentBeforeSave(ApplicationEvents2_DocumentBeforeSaveEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeSave notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_documentbeforesave?view=word-pia"/>
  public void remove_DocumentBeforeSave(ApplicationEvents2_DocumentBeforeSaveEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a new document is created.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_newdocument?view=word-pia"/>
  public void add_NewDocument(ApplicationEvents2_NewDocumentEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to remove from NewDocument notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_newdocument?view=word-pia"/>
  public void remove_NewDocument(ApplicationEvents2_NewDocumentEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowactivate?view=word-pia"/>
  public void add_WindowActivate(ApplicationEvents2_WindowActivateEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowActivate notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_windowactivate?view=word-pia"/>
  public void remove_WindowActivate(ApplicationEvents2_WindowActivateEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowdeactivate?view=word-pia"/>
  public void add_WindowDeactivate(ApplicationEvents2_WindowDeactivateEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowDeactivate notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_windowdeactivate?view=word-pia"/>
  public void remove_WindowDeactivate(ApplicationEvents2_WindowDeactivateEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the selection changes in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowselectionchange?view=word-pia"/>
  public void add_WindowSelectionChange(ApplicationEvents2_WindowSelectionChangeEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSelectionChange notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_windowselectionchange?view=word-pia"/>
  public void remove_WindowSelectionChange(ApplicationEvents2_WindowSelectionChangeEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a right-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowbeforerightclick?view=word-pia"/>
  public void add_WindowBeforeRightClick(ApplicationEvents2_WindowBeforeRightClickEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeRightClick notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_windowbeforerightclick?view=word-pia"/>
  public void remove_WindowBeforeRightClick(ApplicationEvents2_WindowBeforeRightClickEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a double-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowbeforedoubleclick?view=word-pia"/>
  public void add_WindowBeforeDoubleClick(ApplicationEvents2_WindowBeforeDoubleClickEventHandler param1) { throw new NotImplementedException(); }

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeDoubleClick notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.remove_windowbeforedoubleclick?view=word-pia"/>
  public void remove_WindowBeforeDoubleClick(ApplicationEvents2_WindowBeforeDoubleClickEventHandler param1) { throw new NotImplementedException(); }

  #endregion methods
}
