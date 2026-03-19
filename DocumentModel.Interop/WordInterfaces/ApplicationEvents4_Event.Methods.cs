namespace DocumentModel.Interop.Word;

public partial interface ApplicationEvents4_Event
{
  /// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Startup event is raised.</param>
  public void add_Startup(ApplicationEvents4_StartupEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Startup event.</param>
  public void remove_Startup(ApplicationEvents4_StartupEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Quit event is raised.</param>
  public void add_Quit(ApplicationEvents4_QuitEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the Quit event.</param>
  public void remove_Quit(ApplicationEvents4_QuitEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentChange event is raised.</param>
  public void add_DocumentChange(ApplicationEvents4_DocumentChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentChange event.</param>
  public void remove_DocumentChange(ApplicationEvents4_DocumentChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentOpen event is raised.</param>
  public void add_DocumentOpen(ApplicationEvents4_DocumentOpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentOpen event.</param>
  public void remove_DocumentOpen(ApplicationEvents4_DocumentOpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentBeforeClose event is raised.</param>
  public void add_DocumentBeforeClose(ApplicationEvents4_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentBeforeClose event.</param>
  public void remove_DocumentBeforeClose(ApplicationEvents4_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentBeforePrint event is raised.</param>
  public void add_DocumentBeforePrint(ApplicationEvents4_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentBeforePrint event.</param>
  public void remove_DocumentBeforePrint(ApplicationEvents4_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentBeforeSave event is raised.</param>
  public void add_DocumentBeforeSave(ApplicationEvents4_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentBeforeSave event.</param>
  public void remove_DocumentBeforeSave(ApplicationEvents4_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the NewDocument event is raised.</param>
  public void add_NewDocument(ApplicationEvents4_NewDocumentEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the NewDocument event.</param>
  public void remove_NewDocument(ApplicationEvents4_NewDocumentEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowActivate event is raised.</param>
  public void add_WindowActivate(ApplicationEvents4_WindowActivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowActivate event.</param>
  public void remove_WindowActivate(ApplicationEvents4_WindowActivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowDeactivate event is raised.</param>
  public void add_WindowDeactivate(ApplicationEvents4_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowDeactivate event.</param>
  public void remove_WindowDeactivate(ApplicationEvents4_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowSelectionChange event is raised.</param>
  public void add_WindowSelectionChange(ApplicationEvents4_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowSelectionChange event.</param>
  public void remove_WindowSelectionChange(ApplicationEvents4_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowBeforeRightClick event is raised.</param>
  public void add_WindowBeforeRightClick(ApplicationEvents4_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowBeforeRightClick event.</param>
  public void remove_WindowBeforeRightClick(ApplicationEvents4_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowBeforeDoubleClick event is raised.</param>
  public void add_WindowBeforeDoubleClick(ApplicationEvents4_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowBeforeDoubleClick event.</param>
  public void remove_WindowBeforeDoubleClick(ApplicationEvents4_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the EPostagePropertyDialog event is raised.</param>
  public void add_EPostagePropertyDialog(ApplicationEvents4_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the EPostagePropertyDialog event.</param>
  public void remove_EPostagePropertyDialog(ApplicationEvents4_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the EPostageInsert event is raised.</param>
  public void add_EPostageInsert(ApplicationEvents4_EPostageInsertEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the EPostageInsert event.</param>
  public void remove_EPostageInsert(ApplicationEvents4_EPostageInsertEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeAfterMerge event is raised.</param>
  public void add_MailMergeAfterMerge(ApplicationEvents4_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeAfterMerge event.</param>
  public void remove_MailMergeAfterMerge(ApplicationEvents4_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeAfterRecordMerge event is raised.</param>
  public void add_MailMergeAfterRecordMerge(ApplicationEvents4_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeAfterRecordMerge event.</param>
  public void remove_MailMergeAfterRecordMerge(ApplicationEvents4_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeBeforeMerge event is raised.</param>
  public void add_MailMergeBeforeMerge(ApplicationEvents4_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeBeforeMerge event.</param>
  public void remove_MailMergeBeforeMerge(ApplicationEvents4_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeBeforeRecordMerge event is raised.</param>
  public void add_MailMergeBeforeRecordMerge(ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeBeforeRecordMerge event.</param>
  public void remove_MailMergeBeforeRecordMerge(ApplicationEvents4_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeDataSourceLoad event is raised.</param>
  public void add_MailMergeDataSourceLoad(ApplicationEvents4_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeDataSourceLoad event.</param>
  public void remove_MailMergeDataSourceLoad(ApplicationEvents4_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeDataSourceValidate event is raised.</param>
  public void add_MailMergeDataSourceValidate(ApplicationEvents4_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeDataSourceValidate event.</param>
  public void remove_MailMergeDataSourceValidate(ApplicationEvents4_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeWizardSendToCustom event is raised.</param>
  public void add_MailMergeWizardSendToCustom(ApplicationEvents4_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeWizardSendToCustom event.</param>
  public void remove_MailMergeWizardSendToCustom(ApplicationEvents4_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeWizardStateChange event is raised.</param>
  public void add_MailMergeWizardStateChange(ApplicationEvents4_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeWizardStateChange event.</param>
  public void remove_MailMergeWizardStateChange(ApplicationEvents4_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the WindowSize event is raised.</param>
  public void add_WindowSize(ApplicationEvents4_WindowSizeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the WindowSize event.</param>
  public void remove_WindowSize(ApplicationEvents4_WindowSizeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the XMLSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the XMLSelectionChange event is raised.</param>
  public void add_XMLSelectionChange(ApplicationEvents4_XMLSelectionChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the XMLSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the XMLSelectionChange event.</param>
  public void remove_XMLSelectionChange(ApplicationEvents4_XMLSelectionChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the XMLValidationError event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the XMLValidationError event is raised.</param>
  public void add_XMLValidationError(ApplicationEvents4_XMLValidationErrorEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the XMLValidationError event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the XMLValidationError event.</param>
  public void remove_XMLValidationError(ApplicationEvents4_XMLValidationErrorEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentSync event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the DocumentSync event is raised.</param>
  public void add_DocumentSync(ApplicationEvents4_DocumentSyncEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentSync event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the DocumentSync event.</param>
  public void remove_DocumentSync(ApplicationEvents4_DocumentSyncEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostageInsertEx event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the EPostageInsertEx event is raised.</param>
  public void add_EPostageInsertEx(ApplicationEvents4_EPostageInsertExEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostageInsertEx event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the EPostageInsertEx event.</param>
  public void remove_EPostageInsertEx(ApplicationEvents4_EPostageInsertExEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate2 event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the MailMergeDataSourceValidate2 event is raised.</param>
  public void add_MailMergeDataSourceValidate2(ApplicationEvents4_MailMergeDataSourceValidate2EventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceValidate2 event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the MailMergeDataSourceValidate2 event.</param>
  public void remove_MailMergeDataSourceValidate2(ApplicationEvents4_MailMergeDataSourceValidate2EventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowOpen event is raised.</param>
  public void add_ProtectedViewWindowOpen(ApplicationEvents4_ProtectedViewWindowOpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowOpen event.</param>
  public void remove_ProtectedViewWindowOpen(ApplicationEvents4_ProtectedViewWindowOpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowBeforeEdit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowBeforeEdit event is raised.</param>
  public void add_ProtectedViewWindowBeforeEdit(ApplicationEvents4_ProtectedViewWindowBeforeEditEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowBeforeEdit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowBeforeEdit event.</param>
  public void remove_ProtectedViewWindowBeforeEdit(ApplicationEvents4_ProtectedViewWindowBeforeEditEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowBeforeClose event is raised.</param>
  public void add_ProtectedViewWindowBeforeClose(ApplicationEvents4_ProtectedViewWindowBeforeCloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowBeforeClose event.</param>
  public void remove_ProtectedViewWindowBeforeClose(ApplicationEvents4_ProtectedViewWindowBeforeCloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowSize event is raised.</param>
  public void add_ProtectedViewWindowSize(ApplicationEvents4_ProtectedViewWindowSizeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowSize event.</param>
  public void remove_ProtectedViewWindowSize(ApplicationEvents4_ProtectedViewWindowSizeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowActivate event is raised.</param>
  public void add_ProtectedViewWindowActivate(ApplicationEvents4_ProtectedViewWindowActivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowActivate event.</param>
  public void remove_ProtectedViewWindowActivate(ApplicationEvents4_ProtectedViewWindowActivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the ProtectedViewWindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the ProtectedViewWindowDeactivate event is raised.</param>
  public void add_ProtectedViewWindowDeactivate(ApplicationEvents4_ProtectedViewWindowDeactivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the ProtectedViewWindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from the ProtectedViewWindowDeactivate event.</param>
  public void remove_ProtectedViewWindowDeactivate(ApplicationEvents4_ProtectedViewWindowDeactivateEventHandler param1);
}

