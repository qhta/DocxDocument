namespace DocumentModel.Interop.Word;

public partial interface IApplicationEvents2
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
}
