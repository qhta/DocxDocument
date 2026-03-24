namespace DocumentModel.Interfaces;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4?view=word-pia"/>
public partial interface ApplicationEvents4
{
  /// <summary>
  /// Occurs when Microsoft Word starts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.startup?view=word-pia"/>
  public void Startup();

  /// <summary>
  /// Occurs when Microsoft Word is quitting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.quit?view=word-pia"/>
  public void Quit();

  /// <summary>
  /// Occurs when a document is created, opened, or activated.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentchange?view=word-pia"/>
  public void DocumentChange();

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  /// <param name="Doc">The document that was opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentopen?view=word-pia"/>
  public void DocumentOpen(Document Doc);

  /// <summary>
  /// Occurs before a document closes.
  /// </summary>
  /// <param name="Doc">The document being closed.</param>
  /// <param name="Cancel">true to cancel closing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentbeforeclose?view=word-pia"/>
  public void DocumentBeforeClose(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is printed.
  /// </summary>
  /// <param name="Doc">The document being printed.</param>
  /// <param name="Cancel">true to cancel printing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentbeforeprint?view=word-pia"/>
  public void DocumentBeforePrint(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is saved.
  /// </summary>
  /// <param name="Doc">The document being saved.</param>
  /// <param name="SaveAsUI">true if the Save As dialog box is displayed; otherwise, false.</param>
  /// <param name="Cancel">true to cancel saving the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentbeforesave?view=word-pia"/>
  public void DocumentBeforeSave(Document Doc, bool SaveAsUI, ref bool Cancel);

  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  /// <param name="Doc">The new document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.newdocument?view=word-pia"/>
  public void NewDocument(Document Doc);

  /// <summary>
  /// Occurs when a document window is activated.
  /// </summary>
  /// <param name="Doc">The document in the activated window.</param>
  /// <param name="Wn">The window that was activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowactivate?view=word-pia"/>
  public void WindowActivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when a document window is deactivated.
  /// </summary>
  /// <param name="Doc">The document in the deactivated window.</param>
  /// <param name="Wn">The window that was deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowdeactivate?view=word-pia"/>
  public void WindowDeactivate(Document Doc, Window Wn);

  ///// <summary>
  ///// Occurs when the selection changes in a document window.
  ///// </summary>
  ///// <param name="Sel">The selection that changed.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowselectionchange?view=word-pia"/>
  //public void WindowSelectionChange(Selection Sel);

  ///// <summary>
  ///// Occurs before the user right-clicks in a document window.
  ///// </summary>
  ///// <param name="Sel">The selection under the pointer.</param>
  ///// <param name="Cancel">true to cancel the right-click action; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowbeforerightclick?view=word-pia"/>
  //public void WindowBeforeRightClick(Selection Sel, ref bool Cancel);

  ///// <summary>
  ///// Occurs before the user double-clicks in a document window.
  ///// </summary>
  ///// <param name="Sel">The selection under the pointer.</param>
  ///// <param name="Cancel">true to cancel the double-click action; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowbeforedoubleclick?view=word-pia"/>
  //public void WindowBeforeDoubleClick(Selection Sel, ref bool Cancel);

  ///// <summary>
  ///// Occurs when the Electronic Postage Properties dialog box is displayed.
  ///// </summary>
  ///// <param name="Doc">The document associated with the dialog box.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.epostagepropertydialog?view=word-pia"/>
  //public void EPostagePropertyDialog(Document Doc);

  ///// <summary>
  ///// Occurs when electronic postage is inserted into a document.
  ///// </summary>
  ///// <param name="Doc">The document receiving electronic postage.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.epostageinsert?view=word-pia"/>
  //public void EPostageInsert(Document Doc);

  ///// <summary>
  ///// Occurs after a mail merge operation completes.
  ///// </summary>
  ///// <param name="Doc">The main mail merge document.</param>
  ///// <param name="DocResult">The document produced by the merge operation.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergeaftermerge?view=word-pia"/>
  //public void MailMergeAfterMerge(Document Doc, Document DocResult);

  ///// <summary>
  ///// Occurs after each record is merged in a mail merge operation.
  ///// </summary>
  ///// <param name="Doc">The main mail merge document.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergeafterrecordmerge?view=word-pia"/>
  //public void MailMergeAfterRecordMerge(Document Doc);

  ///// <summary>
  ///// Occurs before a mail merge operation begins.
  ///// </summary>
  ///// <param name="Doc">The main mail merge document.</param>
  ///// <param name="StartRecord">The starting record number for the merge.</param>
  ///// <param name="EndRecord">The ending record number for the merge.</param>
  ///// <param name="Cancel">true to cancel the mail merge operation; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergebeforemerge?view=word-pia"/>
  //public void MailMergeBeforeMerge(Document Doc, int StartRecord, int EndRecord, ref bool Cancel);

  ///// <summary>
  ///// Occurs before each record is merged in a mail merge operation.
  ///// </summary>
  ///// <param name="Doc">The main mail merge document.</param>
  ///// <param name="Cancel">true to cancel merging the current record; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergebeforerecordmerge?view=word-pia"/>
  //public void MailMergeBeforeRecordMerge(Document Doc, ref bool Cancel);

  ///// <summary>
  ///// Occurs when a mail merge data source is loaded.
  ///// </summary>
  ///// <param name="Doc">The mail merge document that loaded the data source.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergedatasourceload?view=word-pia"/>
  //public void MailMergeDataSourceLoad(Document Doc);

  ///// <summary>
  ///// Occurs when a mail merge data source is validated.
  ///// </summary>
  ///// <param name="Doc">The mail merge document being validated.</param>
  ///// <param name="Handled">true if validation is handled by the event handler; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergedatasourcevalidate?view=word-pia"/>
  //public void MailMergeDataSourceValidate(Document Doc, bool Handled);

  ///// <summary>
  ///// Occurs when the Mail Merge Wizard sends output to a custom destination.
  ///// </summary>
  ///// <param name="Doc">The mail merge document associated with the wizard operation.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergewizardsendtocustom?view=word-pia"/>
  //public void MailMergeWizardSendToCustom(Document Doc);

  ///// <summary>
  ///// Occurs when the Mail Merge Wizard changes state.
  ///// </summary>
  ///// <param name="Doc">The mail merge document associated with the wizard.</param>
  ///// <param name="FromState">The previous wizard state.</param>
  ///// <param name="ToState">The new wizard state.</param>
  ///// <param name="Handled">true if state handling is performed by the event handler; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergewizardstatechange?view=word-pia"/>
  //public void MailMergeWizardStateChange(Document Doc, int FromState, int ToState, bool Handled);

  ///// <summary>
  ///// Occurs when a document window is resized.
  ///// </summary>
  ///// <param name="Doc">The document in the resized window.</param>
  ///// <param name="Wn">The resized window.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.windowsize?view=word-pia"/>
  //public void WindowSize(Document Doc, Window Wn);

  ///// <summary>
  ///// Occurs when the XML selection context changes.
  ///// </summary>
  ///// <param name="Sel">The current selection.</param>
  ///// <param name="OldXMLNode">The previously selected XML node.</param>
  ///// <param name="NewXMLNode">The newly selected XML node.</param>
  ///// <param name="Reason">The reason code for the XML selection change.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.xmlselectionchange?view=word-pia"/>
  //public void XMLSelectionChange(Selection Sel, XMLNode OldXMLNode, XMLNode NewXMLNode, int Reason);

  ///// <summary>
  ///// Occurs when an XML validation error is raised.
  ///// </summary>
  ///// <param name="XMLNode">The XML node that failed validation.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.xmlvalidationerror?view=word-pia"/>
  //public void XMLValidationError(XMLNode XMLNode);

  ///// <summary>
  ///// Occurs when document synchronization state changes.
  ///// </summary>
  ///// <param name="Doc">The synchronized document.</param>
  ///// <param name="SyncEventType">The synchronization event type.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.documentsync?view=word-pia"/>
  //public void DocumentSync(Document Doc, Core.MsoSyncEventType SyncEventType);

  ///// <summary>
  ///// Occurs when electronic postage insertion with extended information is performed.
  ///// </summary>
  ///// <param name="Doc">The target document.</param>
  ///// <param name="cpDeliveryAddrStart">The start character position of the delivery address.</param>
  ///// <param name="cpDeliveryAddrEnd">The end character position of the delivery address.</param>
  ///// <param name="cpReturnAddrStart">The start character position of the return address.</param>
  ///// <param name="cpReturnAddrEnd">The end character position of the return address.</param>
  ///// <param name="xaWidth">The stamp width.</param>
  ///// <param name="yaHeight">The stamp height.</param>
  ///// <param name="bstrPrinterName">The printer name.</param>
  ///// <param name="bstrPaperFeed">The paper feed setting.</param>
  ///// <param name="fPrint">true to print immediately; otherwise, false.</param>
  ///// <param name="fCancel">true to cancel insertion; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.epostageinsertex?view=word-pia"/>
  //public void EPostageInsertEx(Document Doc, int cpDeliveryAddrStart, int cpDeliveryAddrEnd, int cpReturnAddrStart, int cpReturnAddrEnd, int xaWidth, int yaHeight, string bstrPrinterName, string bstrPaperFeed, bool fPrint, bool fCancel);

  ///// <summary>
  ///// Occurs when a mail merge data source is validated (version 2 event).
  ///// </summary>
  ///// <param name="Doc">The mail merge document being validated.</param>
  ///// <param name="Handled">true if validation is handled by the event handler; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.mailmergedatasourcevalidate2?view=word-pia"/>
  //public void MailMergeDataSourceValidate2(Document Doc, bool Handled);

  ///// <summary>
  ///// Occurs when a protected view window is opened.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window that was opened.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowopen?view=word-pia"/>
  //public void ProtectedViewWindowOpen(ProtectedViewWindow PvWindow);

  ///// <summary>
  ///// Occurs before editing is enabled for a protected view window.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window.</param>
  ///// <param name="Cancel">true to cancel entering edit mode; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowbeforeedit?view=word-pia"/>
  //public void ProtectedViewWindowBeforeEdit(ProtectedViewWindow PvWindow, ref bool Cancel);

  ///// <summary>
  ///// Occurs before a protected view window closes.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window being closed.</param>
  ///// <param name="CloseReason">The reason code for closing the window.</param>
  ///// <param name="Cancel">true to cancel closing; otherwise, false.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowbeforeclose?view=word-pia"/>
  //public void ProtectedViewWindowBeforeClose(ProtectedViewWindow PvWindow, int CloseReason, ref bool Cancel);

  ///// <summary>
  ///// Occurs when a protected view window is resized.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window that was resized.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowsize?view=word-pia"/>
  //public void ProtectedViewWindowSize(ProtectedViewWindow PvWindow);

  ///// <summary>
  ///// Occurs when a protected view window is activated.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window that was activated.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowactivate?view=word-pia"/>
  //public void ProtectedViewWindowActivate(ProtectedViewWindow PvWindow);

  ///// <summary>
  ///// Occurs when a protected view window is deactivated.
  ///// </summary>
  ///// <param name="PvWindow">The protected view window that was deactivated.</param>
  ///// <remarks>
  ///// Microsoft Learn API reference.
  ///// </remarks>
  ///// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4.protectedviewwindowdeactivate?view=word-pia"/>
  //public void ProtectedViewWindowDeactivate(ProtectedViewWindow PvWindow);
}
