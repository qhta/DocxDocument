namespace DocumentModel.Interop.Word;

public partial interface ApplicationEvents3_Event
{
  /// <summary>
  /// Subscribes a handler to the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Startup occurs.</param>
  public void add_Startup(ApplicationEvents3_StartupEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Startup event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Startup notifications.</param>
  public void remove_Startup(ApplicationEvents3_StartupEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when Quit occurs.</param>
  public void add_Quit(ApplicationEvents3_QuitEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the Quit event.
  /// </summary>
  /// <param name="param1">The delegate to remove from Quit notifications.</param>
  public void remove_Quit(ApplicationEvents3_QuitEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when DocumentChange occurs.</param>
  public void add_DocumentChange(ApplicationEvents3_DocumentChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentChange notifications.</param>
  public void remove_DocumentChange(ApplicationEvents3_DocumentChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document is opened.</param>
  public void add_DocumentOpen(ApplicationEvents3_DocumentOpenEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentOpen event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentOpen notifications.</param>
  public void remove_DocumentOpen(ApplicationEvents3_DocumentOpenEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document closes.</param>
  public void add_DocumentBeforeClose(ApplicationEvents3_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeClose event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeClose notifications.</param>
  public void remove_DocumentBeforeClose(ApplicationEvents3_DocumentBeforeCloseEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is printed.</param>
  public void add_DocumentBeforePrint(ApplicationEvents3_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforePrint event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforePrint notifications.</param>
  public void remove_DocumentBeforePrint(ApplicationEvents3_DocumentBeforePrintEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a document is saved.</param>
  public void add_DocumentBeforeSave(ApplicationEvents3_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the DocumentBeforeSave event.
  /// </summary>
  /// <param name="param1">The delegate to remove from DocumentBeforeSave notifications.</param>
  public void remove_DocumentBeforeSave(ApplicationEvents3_DocumentBeforeSaveEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a new document is created.</param>
  public void add_NewDocument(ApplicationEvents3_NewDocumentEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the NewDocument event.
  /// </summary>
  /// <param name="param1">The delegate to remove from NewDocument notifications.</param>
  public void remove_NewDocument(ApplicationEvents3_NewDocumentEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is activated.</param>
  public void add_WindowActivate(ApplicationEvents3_WindowActivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowActivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowActivate notifications.</param>
  public void remove_WindowActivate(ApplicationEvents3_WindowActivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a window is deactivated.</param>
  public void add_WindowDeactivate(ApplicationEvents3_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowDeactivate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowDeactivate notifications.</param>
  public void remove_WindowDeactivate(ApplicationEvents3_WindowDeactivateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the selection changes in a window.</param>
  public void add_WindowSelectionChange(ApplicationEvents3_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSelectionChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSelectionChange notifications.</param>
  public void remove_WindowSelectionChange(ApplicationEvents3_WindowSelectionChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a right-click action in a window.</param>
  public void add_WindowBeforeRightClick(ApplicationEvents3_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeRightClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeRightClick notifications.</param>
  public void remove_WindowBeforeRightClick(ApplicationEvents3_WindowBeforeRightClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before a double-click action in a window.</param>
  public void add_WindowBeforeDoubleClick(ApplicationEvents3_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowBeforeDoubleClick event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowBeforeDoubleClick notifications.</param>
  public void remove_WindowBeforeDoubleClick(ApplicationEvents3_WindowBeforeDoubleClickEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the electronic postage properties dialog is shown.</param>
  public void add_EPostagePropertyDialog(ApplicationEvents3_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostagePropertyDialog event.
  /// </summary>
  /// <param name="param1">The delegate to remove from EPostagePropertyDialog notifications.</param>
  public void remove_EPostagePropertyDialog(ApplicationEvents3_EPostagePropertyDialogEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when electronic postage is inserted.</param>
  public void add_EPostageInsert(ApplicationEvents3_EPostageInsertEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the EPostageInsert event.
  /// </summary>
  /// <param name="param1">The delegate to remove from EPostageInsert notifications.</param>
  public void remove_EPostageInsert(ApplicationEvents3_EPostageInsertEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke after mail merge completes.</param>
  public void add_MailMergeAfterMerge(ApplicationEvents3_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeAfterMerge notifications.</param>
  public void remove_MailMergeAfterMerge(ApplicationEvents3_MailMergeAfterMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke after each mail merge record is merged.</param>
  public void add_MailMergeAfterRecordMerge(ApplicationEvents3_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeAfterRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeAfterRecordMerge notifications.</param>
  public void remove_MailMergeAfterRecordMerge(ApplicationEvents3_MailMergeAfterRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before mail merge begins.</param>
  public void add_MailMergeBeforeMerge(ApplicationEvents3_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeBeforeMerge notifications.</param>
  public void remove_MailMergeBeforeMerge(ApplicationEvents3_MailMergeBeforeMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to invoke before each mail merge record is merged.</param>
  public void add_MailMergeBeforeRecordMerge(ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeBeforeRecordMerge event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeBeforeRecordMerge notifications.</param>
  public void remove_MailMergeBeforeRecordMerge(ApplicationEvents3_MailMergeBeforeRecordMergeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a mail merge data source is loaded.</param>
  public void add_MailMergeDataSourceLoad(ApplicationEvents3_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceLoad event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeDataSourceLoad notifications.</param>
  public void remove_MailMergeDataSourceLoad(ApplicationEvents3_MailMergeDataSourceLoadEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a mail merge data source is validated.</param>
  public void add_MailMergeDataSourceValidate(ApplicationEvents3_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeDataSourceValidate event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeDataSourceValidate notifications.</param>
  public void remove_MailMergeDataSourceValidate(ApplicationEvents3_MailMergeDataSourceValidateEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Mail Merge Wizard sends to a custom destination.</param>
  public void add_MailMergeWizardSendToCustom(ApplicationEvents3_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardSendToCustom event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeWizardSendToCustom notifications.</param>
  public void remove_MailMergeWizardSendToCustom(ApplicationEvents3_MailMergeWizardSendToCustomEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when the Mail Merge Wizard state changes.</param>
  public void add_MailMergeWizardStateChange(ApplicationEvents3_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the MailMergeWizardStateChange event.
  /// </summary>
  /// <param name="param1">The delegate to remove from MailMergeWizardStateChange notifications.</param>
  public void remove_MailMergeWizardStateChange(ApplicationEvents3_MailMergeWizardStateChangeEventHandler param1);

  /// <summary>
  /// Subscribes a handler to the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to invoke when a document window is resized.</param>
  public void add_WindowSize(ApplicationEvents3_WindowSizeEventHandler param1);

  /// <summary>
  /// Unsubscribes a handler from the WindowSize event.
  /// </summary>
  /// <param name="param1">The delegate to remove from WindowSize notifications.</param>
  public void remove_WindowSize(ApplicationEvents3_WindowSizeEventHandler param1);
}
