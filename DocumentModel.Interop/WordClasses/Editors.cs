namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Editor objects that represents a collection of users or groups of users who have been given specific permissions to edit portions of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editors?view=word-pia"/>
public partial class Editors : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editors.count?view=word-pia"/>
  public int Count { get; }
}
