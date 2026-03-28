namespace DocumentModel.Application;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event?view=word-pia"/>
public partial interface ApplicationEvents3_Event
{
  /// <summary>
  /// A handler to the Startup event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_startup?view=word-pia"/>
  public event ApplicationEvents3_StartupEventHandler Startup;

  /// <summary>
  /// A handler to the Quit event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_quit?view=word-pia"/>
  public event ApplicationEvents3_QuitEventHandler Quit;

  /// <summary>
  /// A handler to the DocumentChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentchange?view=word-pia"/>
  public event ApplicationEvents3_DocumentChangeEventHandler DocumentChange;

  /// <summary>
  /// A handler to the DocumentOpen event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentopen?view=word-pia"/>
  public event ApplicationEvents3_DocumentOpenEventHandler DocumentOpen;

  /// <summary>
  /// A handler to the DocumentBeforeClose event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforeclose?view=word-pia"/>
  public event ApplicationEvents3_DocumentBeforeCloseEventHandler DocumentBeforeClose;

  /// <summary>
  /// A handler to the DocumentBeforePrint event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforeprint?view=word-pia"/>
  public event ApplicationEvents3_DocumentBeforePrintEventHandler DocumentBeforePrint;

  /// <summary>
  /// A handler to the DocumentBeforeSave event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforesave?view=word-pia"/>
  public event ApplicationEvents3_DocumentBeforeSaveEventHandler DocumentBeforeSave;

  /// <summary>
  /// A handler to the NewDocument event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_newdocument?view=word-pia"/>
  public event ApplicationEvents3_NewDocumentEventHandler NewDocument;

  /// <summary>
  /// A handler to the WindowActivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowactivate?view=word-pia"/>
  public event ApplicationEvents3_WindowActivateEventHandler WindowActivate;

  /// <summary>
  /// A handler to the WindowDeactivate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowdeactivate?view=word-pia"/>
  public event ApplicationEvents3_WindowDeactivateEventHandler WindowDeactivate;

  /// <summary>
  /// A handler to the WindowSelectionChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowselectionchange?view=word-pia"/>
  public event ApplicationEvents3_WindowSelectionChangeEventHandler WindowSelectionChange;

  /// <summary>
  /// A handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowbeforerightclick?view=word-pia"/>
  public event ApplicationEvents3_WindowBeforeRightClickEventHandler WindowBeforeRightClick;

  /// <summary>
  /// A handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowbeforedoubleclick?view=word-pia"/>
  public event ApplicationEvents3_WindowBeforeDoubleClickEventHandler WindowBeforeDoubleClick;

  /// <summary>
  /// A handler to the EPostagePropertyDialog event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_epostagepropertydialog?view=word-pia"/>
  public event ApplicationEvents3_EPostagePropertyDialogEventHandler EPostagePropertyDialog;

  /// <summary>
  /// A handler to the EPostageInsert event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_epostageinsert?view=word-pia"/>
  public event ApplicationEvents3_EPostageInsertEventHandler EPostageInsert;

  /// <summary>
  /// A handler to the MailMergeAfterMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergeaftermerge?view=word-pia"/>
  public event ApplicationEvents3_MailMergeAfterMergeEventHandler MailMergeAfterMerge;

  /// <summary>
  /// A handler to the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergeafterrecordmerge?view=word-pia"/>
  public event ApplicationEvents3_MailMergeAfterRecordMergeEventHandler MailMergeAfterRecordMerge;

  /// <summary>
  /// A handler to the MailMergeBeforeMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergebeforemerge?view=word-pia"/>
  public event ApplicationEvents3_MailMergeBeforeMergeEventHandler MailMergeBeforeMerge;

  /// <summary>
  /// A handler to the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergebeforerecordmerge?view=word-pia"/>
  public event ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler MailMergeBeforeRecordMerge;

  /// <summary>
  /// A handler to the MailMergeDataSourceLoad event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergedatasourceload?view=word-pia"/>
  public event ApplicationEvents3_MailMergeDataSourceLoadEventHandler MailMergeDataSourceLoad;

  /// <summary>
  /// A handler to the MailMergeDataSourceValidate event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergedatasourcevalidate?view=word-pia"/>
  public event ApplicationEvents3_MailMergeDataSourceValidateEventHandler MailMergeDataSourceValidate;

  /// <summary>
  /// A handler to the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergewizardsendtocustom?view=word-pia"/>
  public event ApplicationEvents3_MailMergeWizardSendToCustomEventHandler MailMergeWizardSendToCustom;

  /// <summary>
  /// A handler to the MailMergeWizardStateChange event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergewizardstatechange?view=word-pia"/>
  public event ApplicationEvents3_MailMergeWizardStateChangeEventHandler MailMergeWizardStateChange;

  /// <summary>
  /// A handler to the WindowSize event.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowsize?view=word-pia"/>
  public event ApplicationEvents3_WindowSizeEventHandler WindowSize;
}
