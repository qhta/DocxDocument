namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event?view=word-pia"/>
public partial interface ApplicationEvents3_Event
{
  /// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Startup occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_startup?view=word-pia"/>
  public void add_Startup(ApplicationEvents3_StartupEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Startup notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_startup?view=word-pia"/>
  public void remove_Startup(ApplicationEvents3_StartupEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Quit occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_quit?view=word-pia"/>
  public void add_Quit(ApplicationEvents3_QuitEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Quit notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_quit?view=word-pia"/>
  public void remove_Quit(ApplicationEvents3_QuitEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when DocumentChange occurs.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentchange?view=word-pia"/>
  public void add_DocumentChange(ApplicationEvents3_DocumentChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentChange notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_documentchange?view=word-pia"/>
  public void remove_DocumentChange(ApplicationEvents3_DocumentChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document is opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentopen?view=word-pia"/>
  public void add_DocumentOpen(ApplicationEvents3_DocumentOpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentOpen notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_documentopen?view=word-pia"/>
  public void remove_DocumentOpen(ApplicationEvents3_DocumentOpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document closes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforeclose?view=word-pia"/>
  public void add_DocumentBeforeClose(ApplicationEvents3_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeClose notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_documentbeforeclose?view=word-pia"/>
  public void remove_DocumentBeforeClose(ApplicationEvents3_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is printed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforeprint?view=word-pia"/>
  public void add_DocumentBeforePrint(ApplicationEvents3_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforePrint notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_documentbeforeprint?view=word-pia"/>
  public void remove_DocumentBeforePrint(ApplicationEvents3_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is saved.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_documentbeforesave?view=word-pia"/>
  public void add_DocumentBeforeSave(ApplicationEvents3_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeSave notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_documentbeforesave?view=word-pia"/>
  public void remove_DocumentBeforeSave(ApplicationEvents3_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a new document is created.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_newdocument?view=word-pia"/>
  public void add_NewDocument(ApplicationEvents3_NewDocumentEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to remove from NewDocument notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_newdocument?view=word-pia"/>
  public void remove_NewDocument(ApplicationEvents3_NewDocumentEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowactivate?view=word-pia"/>
  public void add_WindowActivate(ApplicationEvents3_WindowActivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowActivate notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowactivate?view=word-pia"/>
  public void remove_WindowActivate(ApplicationEvents3_WindowActivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowdeactivate?view=word-pia"/>
  public void add_WindowDeactivate(ApplicationEvents3_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowDeactivate notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowdeactivate?view=word-pia"/>
  public void remove_WindowDeactivate(ApplicationEvents3_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the selection changes in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowselectionchange?view=word-pia"/>
  public void add_WindowSelectionChange(ApplicationEvents3_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSelectionChange notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowselectionchange?view=word-pia"/>
  public void remove_WindowSelectionChange(ApplicationEvents3_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a right-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowbeforerightclick?view=word-pia"/>
  public void add_WindowBeforeRightClick(ApplicationEvents3_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeRightClick notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowbeforerightclick?view=word-pia"/>
  public void remove_WindowBeforeRightClick(ApplicationEvents3_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a double-click action in a window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowbeforedoubleclick?view=word-pia"/>
  public void add_WindowBeforeDoubleClick(ApplicationEvents3_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeDoubleClick notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowbeforedoubleclick?view=word-pia"/>
  public void remove_WindowBeforeDoubleClick(ApplicationEvents3_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the electronic postage properties dialog is shown.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_epostagepropertydialog?view=word-pia"/>
  public void add_EPostagePropertyDialog(ApplicationEvents3_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to remove from EPostagePropertyDialog notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_epostagepropertydialog?view=word-pia"/>
  public void remove_EPostagePropertyDialog(ApplicationEvents3_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when electronic postage is inserted.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_epostageinsert?view=word-pia"/>
  public void add_EPostageInsert(ApplicationEvents3_EPostageInsertEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to remove from EPostageInsert notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_epostageinsert?view=word-pia"/>
  public void remove_EPostageInsert(ApplicationEvents3_EPostageInsertEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke after mail merge completes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergeaftermerge?view=word-pia"/>
  public void add_MailMergeAfterMerge(ApplicationEvents3_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeAfterMerge notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergeaftermerge?view=word-pia"/>
  public void remove_MailMergeAfterMerge(ApplicationEvents3_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke after each mail merge record is merged.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergeafterrecordmerge?view=word-pia"/>
  public void add_MailMergeAfterRecordMerge(ApplicationEvents3_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeAfterRecordMerge notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergeafterrecordmerge?view=word-pia"/>
  public void remove_MailMergeAfterRecordMerge(ApplicationEvents3_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before mail merge begins.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergebeforemerge?view=word-pia"/>
  public void add_MailMergeBeforeMerge(ApplicationEvents3_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeBeforeMerge notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergebeforemerge?view=word-pia"/>
  public void remove_MailMergeBeforeMerge(ApplicationEvents3_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before each mail merge record is merged.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergebeforerecordmerge?view=word-pia"/>
  public void add_MailMergeBeforeRecordMerge(ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeBeforeRecordMerge notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergebeforerecordmerge?view=word-pia"/>
  public void remove_MailMergeBeforeRecordMerge(ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a mail merge data source is loaded.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergedatasourceload?view=word-pia"/>
  public void add_MailMergeDataSourceLoad(ApplicationEvents3_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeDataSourceLoad notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergedatasourceload?view=word-pia"/>
  public void remove_MailMergeDataSourceLoad(ApplicationEvents3_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a mail merge data source is validated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergedatasourcevalidate?view=word-pia"/>
  public void add_MailMergeDataSourceValidate(ApplicationEvents3_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeDataSourceValidate notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergedatasourcevalidate?view=word-pia"/>
  public void remove_MailMergeDataSourceValidate(ApplicationEvents3_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Mail Merge Wizard sends to a custom destination.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergewizardsendtocustom?view=word-pia"/>
  public void add_MailMergeWizardSendToCustom(ApplicationEvents3_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeWizardSendToCustom notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergewizardsendtocustom?view=word-pia"/>
  public void remove_MailMergeWizardSendToCustom(ApplicationEvents3_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Mail Merge Wizard state changes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_mailmergewizardstatechange?view=word-pia"/>
  public void add_MailMergeWizardStateChange(ApplicationEvents3_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeWizardStateChange notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_mailmergewizardstatechange?view=word-pia"/>
  public void remove_MailMergeWizardStateChange(ApplicationEvents3_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document window is resized.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.add_windowsize?view=word-pia"/>
  public void add_WindowSize(ApplicationEvents3_WindowSizeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSize notifications.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3_event.remove_windowsize?view=word-pia"/>
  public void remove_WindowSize(ApplicationEvents3_WindowSizeEventHandler param1);
}
