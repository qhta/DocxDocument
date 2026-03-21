namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single user who has been given specific permissions to edit portions of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor?view=word-pia"/>
public partial interface Editor : InteropObject
{
  /// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.delete?view=word-pia"/>
  public void Delete();

  /// <summary>
  /// Deletes all editing permissions in a document for a specific user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.deleteall?view=word-pia"/>
  public void DeleteAll();

  /// <summary>
  /// Selects all the shapes in a document that were inserted or edited by this user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.selectall?view=word-pia"/>
  public void SelectAll();
}
