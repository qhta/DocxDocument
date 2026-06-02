namespace DocumentModel.Interop.Word;

/// <summary>
/// Events interface for WordApplication object events.This is a .NET interface created when processing a COM coclass that is required by managed code for interoperability with the corresponding COM object. This interface implements all events of earlier interfaces and any additional new events. Use this interface only when the event you want to use shares the same name as a method of the COM object; in this case, cast to this interface to connect to the event, and cast to the primary interface to call the method. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event?view=word-pia"/>
public partial interface IApplicationEvents4
{

  /// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_startup?view=word-pia"/>
  public event ApplicationEvents4_StartupEventHandler Startup;

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_quit?view=word-pia"/>
  public event ApplicationEvents4_QuitEventHandler Quit;

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentchange?view=word-pia"/>
  public event ApplicationEvents4_DocumentChangeEventHandler DocumentChange;
  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentopen?view=word-pia"/>
  public event ApplicationEvents4_DocumentOpenEventHandler DocumentOpen;

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentbeforeclose?view=word-pia"/>
  public event ApplicationEvents4_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentbeforeprint?view=word-pia"/>
  public event ApplicationEvents4_DocumentBeforePrintEventHandler DocumentBeforePrint;

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentbeforesave?view=word-pia"/>
  public event ApplicationEvents4_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_newdocument?view=word-pia"/>
  public event ApplicationEvents4_NewDocumentEventHandler NewDocument;

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowactivate?view=word-pia"/>
  public event ApplicationEvents4_WindowActivateEventHandler WindowActivate;

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowdeactivate?view=word-pia"/>
  public event ApplicationEvents4_WindowDeactivateEventHandler WindowDeactivate;

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowselectionchange?view=word-pia"/>
  public event ApplicationEvents4_WindowSelectionChangeEventHandler WindowSelectionChange;

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowbeforerightclick?view=word-pia"/>
  public event ApplicationEvents4_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowbeforedoubleclick?view=word-pia"/>
  public event ApplicationEvents4_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  /// <summary>
  /// Subscribes a handler to the EPostagePropertyDialog event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_epostagepropertydialog?view=word-pia"/>
  public event ApplicationEvents4_EPostagePropertyDialogEventHandler EPostagePropertyDialog;

  /// <summary>
  /// Subscribes a handler to the EPostageInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_epostageinsert?view=word-pia"/>
  public event ApplicationEvents4_EPostageInsertEventHandler EPostageInsert;

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergeaftermerge?view=word-pia"/>
  public event ApplicationEvents4_MailMergeAfterMergeEventHandler MailMergeAfterMerge;

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergeafterrecordmerge?view=word-pia"/>
  public event ApplicationEvents4_MailMergeAfterRecordMergeEventHandler MailMergeAfterRecordMerge;

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergebeforemerge?view=word-pia"/>
  public event ApplicationEvents4_MailMergeBeforeMergeEventHandler MailMergeBeforeMerge;

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergebeforerecordmerge?view=word-pia"/>
  public event ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler MailMergeBeforeRecordMerge;

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceLoad event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergedatasourceload?view=word-pia"/>
  public event ApplicationEvents4_MailMergeDataSourceLoadEventHandler MailMergeDataSourceLoad;

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergedatasourcevalidate?view=word-pia"/>
  public event ApplicationEvents4_MailMergeDataSourceValidateEventHandler MailMergeDataSourceValidate;

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergewizardsendtocustom?view=word-pia"/>
  public event ApplicationEvents4_MailMergeWizardSendToCustomEventHandler MailMergeWizardSendToCustom;

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardStateChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergewizardstatechange?view=word-pia"/>
  public event ApplicationEvents4_MailMergeWizardStateChangeEventHandler MailMergeWizardStateChange;

  /// <summary>
  /// Subscribes a handler to the WindowSize event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_windowsize?view=word-pia"/>
  public event ApplicationEvents4_WindowSizeEventHandler WindowSize;

  /// <summary>
  /// Subscribes a handler to the XMLSelectionChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_xmlselectionchange?view=word-pia"/>
  public event ApplicationEvents4_XMLSelectionChangeEventHandler XMLSelectionChange;

  /// <summary>
  /// Subscribes a handler to the XMLValidationError event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_xmlvalidationerror?view=word-pia"/>
  public event ApplicationEvents4_XMLValidationErrorEventHandler XMLValidationError;

  /// <summary>
  /// Subscribes a handler to the DocumentSync event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_documentsync?view=word-pia"/>
  public event ApplicationEvents4_DocumentSyncEventHandler DocumentSync;

  /// <summary>
  /// Subscribes a handler to the EPostageInsertEx event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_epostageinsertex?view=word-pia"/>
  public event ApplicationEvents4_EPostageInsertExEventHandler EPostageInsertEx;

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate2 event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_mailmergedatasourcevalidate2?view=word-pia"/>
  public event ApplicationEvents4_MailMergeDataSourceValidate2EventHandler MailMergeDataSourceValidate2;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowOpen event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowopen?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowOpenEventHandler ProtectedViewWindowOpen;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowBeforeEdit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowbeforeedit?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowBeforeEditEventHandler ProtectedViewWindowBeforeEdit;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowBeforeClose event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowbeforeclose?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowBeforeCloseEventHandler ProtectedViewWindowBeforeClose;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowSize event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowsize?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowSizeEventHandler ProtectedViewWindowSize;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowActivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowactivate?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowActivateEventHandler ProtectedViewWindowActivate;

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowDeactivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event.add_protectedviewwindowdeactivate?view=word-pia"/>
  public event ApplicationEvents4_ProtectedViewWindowDeactivateEventHandler ProtectedViewWindowDeactivate;
}
