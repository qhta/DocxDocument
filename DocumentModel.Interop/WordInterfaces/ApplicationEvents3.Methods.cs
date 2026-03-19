namespace DocumentModel.Interop.Word;

public partial interface ApplicationEvents3
{
  /// <summary>
  /// Occurs when Microsoft Word starts.
  /// </summary>
  public void Startup();

  /// <summary>
  /// Occurs when Microsoft Word is quitting.
  /// </summary>
  public void Quit();

  /// <summary>
  /// Occurs when a document is created, opened, or activated.
  /// </summary>
  public void DocumentChange();

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  /// <param name="Doc">The document that was opened.</param>
  public void DocumentOpen(Document Doc);

  /// <summary>
  /// Occurs before a document closes.
  /// </summary>
  /// <param name="Doc">The document being closed.</param>
  /// <param name="Cancel">true to cancel closing the document; otherwise, false.</param>
  public void DocumentBeforeClose(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is printed.
  /// </summary>
  /// <param name="Doc">The document being printed.</param>
  /// <param name="Cancel">true to cancel printing the document; otherwise, false.</param>
  public void DocumentBeforePrint(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is saved.
  /// </summary>
  /// <param name="Doc">The document being saved.</param>
  /// <param name="SaveAsUI">true if the Save As dialog box is displayed; otherwise, false.</param>
  /// <param name="Cancel">true to cancel saving the document; otherwise, false.</param>
  public void DocumentBeforeSave(Document Doc, bool SaveAsUI, ref bool Cancel);

  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  /// <param name="Doc">The new document.</param>
  public void NewDocument(Document Doc);

  /// <summary>
  /// Occurs when a document window is activated.
  /// </summary>
  /// <param name="Doc">The document in the activated window.</param>
  /// <param name="Wn">The window that was activated.</param>
  public void WindowActivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when a document window is deactivated.
  /// </summary>
  /// <param name="Doc">The document in the deactivated window.</param>
  /// <param name="Wn">The window that was deactivated.</param>
  public void WindowDeactivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when the selection changes in a document window.
  /// </summary>
  /// <param name="Sel">The selection that changed.</param>
  public void WindowSelectionChange(Selection Sel);

  /// <summary>
  /// Occurs before the user right-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the right-click action; otherwise, false.</param>
  public void WindowBeforeRightClick(Selection Sel, ref bool Cancel);

  /// <summary>
  /// Occurs before the user double-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the double-click action; otherwise, false.</param>
  public void WindowBeforeDoubleClick(Selection Sel, ref bool Cancel);

  /// <summary>
  /// Occurs when the Electronic Postage Properties dialog box is displayed.
  /// </summary>
  /// <param name="Doc">The document associated with the dialog box.</param>
  public void EPostagePropertyDialog(Document Doc);

  /// <summary>
  /// Occurs when electronic postage is inserted into a document.
  /// </summary>
  /// <param name="Doc">The document receiving electronic postage.</param>
  public void EPostageInsert(Document Doc);

  /// <summary>
  /// Occurs after a mail merge operation completes.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="DocResult">The document produced by the merge operation.</param>
  public void MailMergeAfterMerge(Document Doc, Document DocResult);

  /// <summary>
  /// Occurs after each record is merged in a mail merge operation.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  public void MailMergeAfterRecordMerge(Document Doc);

  /// <summary>
  /// Occurs before a mail merge operation begins.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="StartRecord">The starting record number for the merge.</param>
  /// <param name="EndRecord">The ending record number for the merge.</param>
  /// <param name="Cancel">true to cancel the mail merge operation; otherwise, false.</param>
  public void MailMergeBeforeMerge(Document Doc, int StartRecord, int EndRecord, ref bool Cancel);

  /// <summary>
  /// Occurs before each record is merged in a mail merge operation.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="Cancel">true to cancel merging the current record; otherwise, false.</param>
  public void MailMergeBeforeRecordMerge(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs when a mail merge data source is loaded.
  /// </summary>
  /// <param name="Doc">The mail merge document that loaded the data source.</param>
  public void MailMergeDataSourceLoad(Document Doc);

  /// <summary>
  /// Occurs when a mail merge data source is validated.
  /// </summary>
  /// <param name="Doc">The mail merge document being validated.</param>
  /// <param name="Handled">true if validation is handled by the event handler; otherwise, false.</param>
  public void MailMergeDataSourceValidate(Document Doc, bool Handled);

  /// <summary>
  /// Occurs when the Mail Merge Wizard sends output to a custom destination.
  /// </summary>
  /// <param name="Doc">The mail merge document associated with the wizard operation.</param>
  public void MailMergeWizardSendToCustom(Document Doc);

  /// <summary>
  /// Occurs when the Mail Merge Wizard changes state.
  /// </summary>
  /// <param name="Doc">The mail merge document associated with the wizard.</param>
  /// <param name="FromState">The previous wizard state.</param>
  /// <param name="ToState">The new wizard state.</param>
  /// <param name="Handled">true if state handling is performed by the event handler; otherwise, false.</param>
  public void MailMergeWizardStateChange(Document Doc, int FromState, int ToState, bool Handled);

  /// <summary>
  /// Occurs when a document window is resized.
  /// </summary>
  /// <param name="Doc">The document in the resized window.</param>
  /// <param name="Wn">The resized window.</param>
  public void WindowSize(Document Doc, Window Wn);
}
