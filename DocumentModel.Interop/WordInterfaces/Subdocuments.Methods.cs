namespace DocumentModel.Interop.Word;

public partial interface Subdocuments
{
  /// <summary>
  /// Adds a subdocument from a file to the collection.
  /// </summary>
  /// <param name="Name">The name or path of the file to add as a subdocument.</param>
  /// <param name="ConfirmConversions">true to confirm file format conversions; otherwise, false.</param>
  /// <param name="ReadOnly">true to open the file as read-only; otherwise, false.</param>
  /// <param name="PasswordDocument">The password for opening the document, if required.</param>
  /// <param name="PasswordTemplate">The password for opening the template, if required.</param>
  /// <param name="Revert">true to revert to the last saved version; otherwise, false.</param>
  /// <param name="WritePasswordDocument">The write password for the document, if required.</param>
  /// <param name="WritePasswordTemplate">The write password for the template, if required.</param>
  /// <returns>The created <see cref="Subdocument"/> object.</returns>
  public Subdocument AddFromFile(string Name, bool ConfirmConversions, bool ReadOnly, string PasswordDocument, 
    string PasswordTemplate, bool Revert, string WritePasswordDocument, string WritePasswordTemplate);
}
