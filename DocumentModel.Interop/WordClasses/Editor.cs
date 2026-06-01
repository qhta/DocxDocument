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
  public string ID { get; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a range that represents the next range for which a user has permissions to modify.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.nextrange?view=word-pia"/>
  public Range NextRange { get; }

  /// <summary>
  /// Returns a range that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editor.range?view=word-pia"/>
  public Range Range { get; }
}
