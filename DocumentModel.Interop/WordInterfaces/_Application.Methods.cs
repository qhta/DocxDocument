namespace DocumentModel.Interop.Word;

public partial interface _Application
{
  /// <summary>
  /// The international.
  /// </summary>
  public object get_International(WdInternationalIndex Index);

  /// <summary>
  /// The synonym info.
  /// </summary>
  public SynonymInfo get_SynonymInfo(string Word, object LanguageID);

  /// <summary>
  /// The keys bound to.
  /// </summary>
  public KeysBoundTo get_KeysBoundTo(WdKeyCategory KeyCategory, string Command, object CommandParameter);

  /// <summary>
  /// The is object valid.
  /// </summary>
  public bool get_IsObjectValid(object Object);

  /// <summary>
  /// The file dialog.
  /// </summary>
  public Core.FileDialog get_FileDialog(Core.MsoFileDialogType FileDialogType);

  /// <summary>
  /// Quits Microsoft Word and optionally saves or routes the open documents.
  /// </summary>
  public void Quit(object SaveChanges, object OriginalFormat, object RouteDocument);
}
