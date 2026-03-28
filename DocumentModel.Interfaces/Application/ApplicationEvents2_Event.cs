namespace DocumentModel.Application;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event?view=word-pia"/>
public partial interface ApplicationEvents2_Event
{
  /// <summary>
  /// A handler to the Startup event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_startup?view=word-pia"/>
  public event ApplicationEvents2_StartupEventHandler Startup;

  /// <summary>
  /// A handler to the Quit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_quit?view=word-pia"/>
  public event ApplicationEvents2_QuitEventHandler Quit;

  /// <summary>
  /// A handler to the DocumentChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentchange?view=word-pia"/>
  public event ApplicationEvents2_DocumentChangeEventHandler DocumentChange;

  /// <summary>
  /// A handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document is opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentopen?view=word-pia"/>
  public event ApplicationEvents2_DocumentOpenEventHandler DocumentOpen;

  /// <summary>
  /// A handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document closes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforeclose?view=word-pia"/>
  public event ApplicationEvents2_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  /// <summary>
  /// A handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is printed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforeprint?view=word-pia"/>
  public event ApplicationEvents2_DocumentBeforePrintEventHandler DocumentBeforePrint;

  /// <summary>
  /// A handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is saved.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_documentbeforesave?view=word-pia"/>
  public event ApplicationEvents2_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  /// <summary>
  /// A handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a new document is created.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_newdocument?view=word-pia"/>
  public event ApplicationEvents2_NewDocumentEventHandler NewDocument;

  /// <summary>
  /// A handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowactivate?view=word-pia"/>
  public event ApplicationEvents2_WindowActivateEventHandler WindowActivate;

  /// <summary>
  /// A handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowdeactivate?view=word-pia"/>
  public event ApplicationEvents2_WindowDeactivateEventHandler WindowDeactivate;

  /// <summary>
  /// A handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the selection changes in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowselectionchange?view=word-pia"/>
  public event ApplicationEvents2_WindowSelectionChangeEventHandler WindowSelectionChange;

  /// <summary>
  /// A handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a right-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowbeforerightclick?view=word-pia"/>
  public event ApplicationEvents2_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  /// <summary>
  /// A handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a double-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2_event.add_windowbeforedoubleclick?view=word-pia"/>
  public event ApplicationEvents2_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;


}
