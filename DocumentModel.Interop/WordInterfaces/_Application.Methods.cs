namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application?view=word-pia"/>
public partial interface _Application
{
  /// <summary>
  /// The international.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_international?view=word-pia"/>
  public object get_International(WdInternationalIndex Index);

  /// <summary>
  /// The synonym info.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_synonyminfo?view=word-pia"/>
  public SynonymInfo get_SynonymInfo(string Word, object LanguageID);

  /// <summary>
  /// The keys bound to.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_keysboundto?view=word-pia"/>
  public KeysBoundTo get_KeysBoundTo(WdKeyCategory KeyCategory, string Command, object CommandParameter);

  /// <summary>
  /// The is object valid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_isobjectvalid?view=word-pia"/>
  public bool get_IsObjectValid(object Object);

  /// <summary>
  /// The file dialog.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_filedialog?view=word-pia"/>
  public Core.FileDialog get_FileDialog(Core.MsoFileDialogType FileDialogType);

  /// <summary>
  /// Quits Microsoft Word and optionally saves or routes the open documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.quit?view=word-pia"/>
  public void Quit(object SaveChanges, object OriginalFormat, object RouteDocument);
}
