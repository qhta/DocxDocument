namespace DocumentModel.Interop.Word;

public partial interface IApplicationEvents3
{
  /// <summary>
  /// Occurs when the application starts up.
  /// </summary>
  public void Startup();

  /// <summary>
  /// Occurs when the application is quitting.
  /// </summary>
  public void Quit();

  /// <summary>
  /// Occurs when the active document changes.
  /// </summary>
  public void DocumentChange();

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  /// <param name="Doc">The document that was opened.</param>
  public void DocumentOpen(Document Doc);

  /// <summary>
  /// Occurs before a document is closed.
  /// </summary>
  /// <param name="Doc">The document to be closed.</param>
  /// <param name="Cancel">true to cancel the close operation; otherwise, false.</param>
  public void DocumentBeforeClose(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is printed.
  /// </summary>
  /// <param name="Doc">The document to be printed.</param>
  /// <param name="Cancel">true to cancel the print operation; otherwise, false.</param>
  public void DocumentBeforePrint(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is saved.
  /// </summary>
  /// <param name="Doc">The document to be saved.</param>
  /// <param name="SaveAsUI">true if the Save As dialog box is displayed; otherwise, false.</param>
  /// <param name="Cancel">true to cancel the save operation; otherwise, false.</param>
  public void DocumentBeforeSave(Document Doc, bool SaveAsUI, ref bool Cancel);

  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  /// <param name="Doc">The new document.</param>
  public void NewDocument(Document Doc);

  /// <summary>
  /// Occurs when a window is activated.
  /// </summary>
  /// <param name="Doc">The document in the activated window.</param>
  /// <param name="Wn">The window that was activated.</param>
  public void WindowActivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when a window is deactivated.
  /// </summary>
  /// <param name="Doc">The document in the deactivated window.</param>
  /// <param name="Wn">The window that was deactivated.</param>
  public void WindowDeactivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when the selection changes in a window.
  /// </summary>
  /// <param name="Sel">The new selection.</param>
  public void WindowSelectionChange(Selection Sel);

  /// <summary>
  /// Occurs before a right-click in a window.
  /// </summary>
  /// <param name="Sel">The selection at the time of the right-click.</param>
  /// <param name="Cancel">true to cancel the right-click action; otherwise, false.</param>
  public void WindowBeforeRightClick(Selection Sel, ref bool Cancel);

  /// <summary>
  /// Occurs before a double-click in a window.
  /// </summary>
  /// <param name="Sel">The selection at the time of the double-click.</param>
  /// <param name="Cancel">true to cancel the double-click action; otherwise, false.</param>
  public void WindowBeforeDoubleClick(Selection Sel, ref bool Cancel);

  /// <summary>
  /// Occurs when the e-postage property dialog is displayed.
  /// </summary>
  /// <param name="Doc">The document for which the dialog is displayed.</param>
  public void EPostagePropertyDialog(Document Doc);

  /// <summary>
  /// Occurs when e-postage is inserted into a document.
  /// </summary>
  /// <param name="Doc">The document into which e-postage is inserted.</param>
  public void EPostageInsert(Document Doc);

  /// <summary>
  /// Occurs after a mail merge is completed.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  /// <param name="DocResult">The resulting document after the merge.</param>
  public void MailMergeAfterMerge(Document Doc, Document DocResult);

  /// <summary>
  /// Occurs after a mail merge record is merged.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  public void MailMergeAfterRecordMerge(Document Doc);

  /// <summary>
  /// Occurs before a mail merge is performed.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  /// <param name="StartRecord">The first record to merge.</param>
  /// <param name="EndRecord">The last record to merge.</param>
  /// <param name="Cancel">true to cancel the merge; otherwise, false.</param>
  public void MailMergeBeforeMerge(Document Doc, int StartRecord, int EndRecord, ref bool Cancel);

  /// <summary>
  /// Occurs before a mail merge record is merged.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  /// <param name="Cancel">true to cancel the merge; otherwise, false.</param>
  public void MailMergeBeforeRecordMerge(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs when a mail merge data source is loaded.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  public void MailMergeDataSourceLoad(Document Doc);

  /// <summary>
  /// Occurs when a mail merge data source is validated.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  /// <param name="Handled">true if the validation was handled; otherwise, false.</param>
  public void MailMergeDataSourceValidate(Document Doc, bool Handled);

  /// <summary>
  /// Occurs when the mail merge wizard sends to a custom recipient.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  public void MailMergeWizardSendToCustom(Document Doc);

  /// <summary>
  /// Occurs when the mail merge wizard state changes.
  /// </summary>
  /// <param name="Doc">The main document.</param>
  /// <param name="FromState">The previous state.</param>
  /// <param name="ToState">The new state.</param>
  /// <param name="Handled">true if the state change was handled; otherwise, false.</param>
  public void MailMergeWizardStateChange(Document Doc, int FromState, int ToState, bool Handled);

  /// <summary>
  /// Occurs when a window is resized.
  /// </summary>
  /// <param name="Doc">The document in the resized window.</param>
  /// <param name="Wn">The window that was resized.</param>
  public void WindowSize(Document Doc, Window Wn);
}
