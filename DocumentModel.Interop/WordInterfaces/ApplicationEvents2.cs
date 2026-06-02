namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2?view=word-pia"/>
public partial interface IApplicationEvents2
{


  #region methods

/// <summary>
  /// Occurs when Microsoft Word starts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.startup?view=word-pia"/>
  public void Startup();

  /// <summary>
  /// Occurs when Microsoft Word is quitting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.quit?view=word-pia"/>
  public void Quit();

  /// <summary>
  /// Occurs when a document is created, opened, or activated.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.documentchange?view=word-pia"/>
  public void DocumentChange();

  /// <summary>
  /// Occurs when a document is opened.
  /// </summary>
  /// <param name="Doc">The document that was opened.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.documentopen?view=word-pia"/>
  public void DocumentOpen(Document Doc);

  /// <summary>
  /// Occurs before a document closes.
  /// </summary>
  /// <param name="Doc">The document being closed.</param>
  /// <param name="Cancel">true to cancel closing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.documentbeforeclose?view=word-pia"/>
  public void DocumentBeforeClose(Document Doc, ref bool Cancel);

  /// <summary>
  /// Occurs before a document is printed.
  /// </summary>
  /// <param name="Doc">The document being printed.</param>
  /// <param name="Cancel">true to cancel printing the document; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.documentbeforeprint?view=word-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.documentbeforesave?view=word-pia"/>
  public void DocumentBeforeSave(Document Doc, bool SaveAsUI, ref bool Cancel);

  /// <summary>
  /// Occurs when a new document is created.
  /// </summary>
  /// <param name="Doc">The new document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.newdocument?view=word-pia"/>
  public void NewDocument(Document Doc);

  /// <summary>
  /// Occurs when a document window is activated.
  /// </summary>
  /// <param name="Doc">The document in the activated window.</param>
  /// <param name="Wn">The window that was activated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.windowactivate?view=word-pia"/>
  public void WindowActivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when a document window is deactivated.
  /// </summary>
  /// <param name="Doc">The document in the deactivated window.</param>
  /// <param name="Wn">The window that was deactivated.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.windowdeactivate?view=word-pia"/>
  public void WindowDeactivate(Document Doc, Window Wn);

  /// <summary>
  /// Occurs when the selection changes in a document window.
  /// </summary>
  /// <param name="Sel">The selection that changed.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.windowselectionchange?view=word-pia"/>
  public void WindowSelectionChange(Selection Sel);

  /// <summary>
  /// Occurs before the user right-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the right-click action; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.windowbeforerightclick?view=word-pia"/>
  public void WindowBeforeRightClick(Selection Sel, ref bool Cancel);

  /// <summary>
  /// Occurs before the user double-clicks in a document window.
  /// </summary>
  /// <param name="Sel">The selection under the pointer.</param>
  /// <param name="Cancel">true to cancel the double-click action; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents2.windowbeforedoubleclick?view=word-pia"/>
  public void WindowBeforeDoubleClick(Selection Sel, ref bool Cancel);

  #endregion methods
}
