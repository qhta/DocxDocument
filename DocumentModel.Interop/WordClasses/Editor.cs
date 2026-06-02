namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single user who has been given specific permissions to edit portions of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor?view=word-pia"/>
public partial class Editor : InteropObject
{
  /// <summary>
  /// Returns the identifying label for the specified object when the current document is saved as a Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.id?view=word-pia"/>
  public string? ID { get; set; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Returns a range that represents the next range for which a user has permissions to modify.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.nextrange?view=word-pia"/>
  public Range NextRange { get; set; }

  /// <summary>
  /// Returns a range that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.range?view=word-pia"/>
  public Range Range { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes all editing permissions in a document for a specific user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.deleteall?view=word-pia"/>
  public void DeleteAll() { throw new NotImplementedException(); }

  /// <summary>
  /// Selects all the shapes in the main story, in a canvas, or in headers and footers of a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.selectall?view=word-pia"/>
  public void SelectAll() { throw new NotImplementedException(); }

  #endregion methods
}
