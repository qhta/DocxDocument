namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3?view=word-pia"/>
public partial class ApplicationEvents3
{


  #region methods

/// <summary>
  /// Occurs when Microsoft Word starts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.startup?view=word-pia"/>
  public void Startup() { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when Microsoft Word is quitting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.quit?view=word-pia"/>
  public void Quit() { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a document is created, opened, or activated.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.documentchange?view=word-pia"/>
  public void DocumentChange() { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  /// <param name="Doc">The document that was opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.documentopen?view=word-pia"/>
  public void DocumentOpen(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before a document closes.
  /// </summary>
  /// <param name="Doc">The document being closed.</param>
  /// <param name="Cancel">true to cancel closing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.documentbeforeclose?view=word-pia"/>
  public void DocumentBeforeClose(Document Doc, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before a document is printed.
  /// </summary>
  /// <param name="Doc">The document being printed.</param>
  /// <param name="Cancel">true to cancel printing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.documentbeforeprint?view=word-pia"/>
  public void DocumentBeforePrint(Document Doc, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before a document is saved.
  /// </summary>
  /// <param name="Doc">The document being saved.</param>
  /// <param name="SaveAsUI">true if the Save As dialog box is displayed; otherwise, false.</param>
  /// <param name="Cancel">true to cancel saving the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.documentbeforesave?view=word-pia"/>
  public void DocumentBeforeSave(Document Doc, bool SaveAsUI, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  /// <param name="Doc">The new document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.newdocument?view=word-pia"/>
  public void NewDocument(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a document window is activated.
  /// </summary>
  /// <param name="Doc">The document in the activated window.</param>
  /// <param name="Wn">The window that was activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowactivate?view=word-pia"/>
  public void WindowActivate(Document Doc, Window Wn) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a document window is deactivated.
  /// </summary>
  /// <param name="Doc">The document in the deactivated window.</param>
  /// <param name="Wn">The window that was deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowdeactivate?view=word-pia"/>
  public void WindowDeactivate(Document Doc, Window Wn) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when the selection changes in a document window.
  /// </summary>
  /// <param name="Sel">The selection that changed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowselectionchange?view=word-pia"/>
  public void WindowSelectionChange(Selection Sel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before the user right-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the right-click action; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowbeforerightclick?view=word-pia"/>
  public void WindowBeforeRightClick(Selection Sel, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before the user double-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the double-click action; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowbeforedoubleclick?view=word-pia"/>
  public void WindowBeforeDoubleClick(Selection Sel, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when the Electronic Postage Properties dialog box is displayed.
  /// </summary>
  /// <param name="Doc">The document associated with the dialog box.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.epostagepropertydialog?view=word-pia"/>
  public void EPostagePropertyDialog(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when electronic postage is inserted into a document.
  /// </summary>
  /// <param name="Doc">The document receiving electronic postage.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.epostageinsert?view=word-pia"/>
  public void EPostageInsert(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs after a mail merge operation completes.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="DocResult">The document produced by the merge operation.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergeaftermerge?view=word-pia"/>
  public void MailMergeAfterMerge(Document Doc, Document DocResult) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs after each record is merged in a mail merge operation.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergeafterrecordmerge?view=word-pia"/>
  public void MailMergeAfterRecordMerge(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before a mail merge operation begins.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="StartRecord">The starting record number for the merge.</param>
  /// <param name="EndRecord">The ending record number for the merge.</param>
  /// <param name="Cancel">true to cancel the mail merge operation; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergebeforemerge?view=word-pia"/>
  public void MailMergeBeforeMerge(Document Doc, int StartRecord, int EndRecord, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs before each record is merged in a mail merge operation.
  /// </summary>
  /// <param name="Doc">The main mail merge document.</param>
  /// <param name="Cancel">true to cancel merging the current record; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergebeforerecordmerge?view=word-pia"/>
  public void MailMergeBeforeRecordMerge(Document Doc, ref bool Cancel) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a mail merge data source is loaded.
  /// </summary>
  /// <param name="Doc">The mail merge document that loaded the data source.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergedatasourceload?view=word-pia"/>
  public void MailMergeDataSourceLoad(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a mail merge data source is validated.
  /// </summary>
  /// <param name="Doc">The mail merge document being validated.</param>
  /// <param name="Handled">true if validation is handled by the event handler; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergedatasourcevalidate?view=word-pia"/>
  public void MailMergeDataSourceValidate(Document Doc, bool Handled) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when the Mail Merge Wizard sends output to a custom destination.
  /// </summary>
  /// <param name="Doc">The mail merge document associated with the wizard operation.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergewizardsendtocustom?view=word-pia"/>
  public void MailMergeWizardSendToCustom(Document Doc) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when the Mail Merge Wizard changes state.
  /// </summary>
  /// <param name="Doc">The mail merge document associated with the wizard.</param>
  /// <param name="FromState">The previous wizard state.</param>
  /// <param name="ToState">The new wizard state.</param>
  /// <param name="Handled">true if state handling is performed by the event handler; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.mailmergewizardstatechange?view=word-pia"/>
  public void MailMergeWizardStateChange(Document Doc, int FromState, int ToState, bool Handled) { throw new NotImplementedException(); }

  /// <summary>
  /// Occurs when a document window is resized.
  /// </summary>
  /// <param name="Doc">The document in the resized window.</param>
  /// <param name="Wn">The resized window.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents3.windowsize?view=word-pia"/>
  public void WindowSize(Document Doc, Window Wn) { throw new NotImplementedException(); }

  #endregion methods
}
