namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application?view=word-pia"/>
public partial interface _Application
{
  /// <summary>
  /// Returns information about the current country/region and international settings.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.international?view=word-pia"/>
  public object International(WdInternationalIndex Index);

  /// <summary>
  /// Returns a SynonymInfo object that contains information from the thesaurus on synonyms, antonyms, or related
  /// words and expressions for the specified word or phrase.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_synonyminfo?view=word-pia"/>
  public SynonymInfo SynonymInfo(string Word, object LanguageID);

  /// <summary>
  /// Returns a KeysBoundTo object that represents all the key combinations assigned to the specified item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_keysboundto?view=word-pia"/>
  public KeysBoundTo KeysBoundTo(WdKeyCategory KeyCategory, string Command, object CommandParameter);

  /// <summary>
  /// Determines if the specified variable that references an object is valid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_isobjectvalid?view=word-pia"/>
  public bool IsObjectValid(object Object);

  /// <summary>
  /// Returns a FileDialog object which represents a single instance of a file dialog box.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.get_filedialog?view=word-pia"/>
  public Core.FileDialog FileDialog(Core.MsoFileDialogType FileDialogType);

  /// <summary>
  /// Quits Microsoft Word and optionally saves or routes the open documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._application.quit?view=word-pia"/>
  public void Quit(object SaveChanges, object OriginalFormat, object RouteDocument);
}
