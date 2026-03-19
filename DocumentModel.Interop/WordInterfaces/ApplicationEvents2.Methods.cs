namespace DocumentModel.Interop.Word;

public partial interface ApplicationEvents2
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
}
