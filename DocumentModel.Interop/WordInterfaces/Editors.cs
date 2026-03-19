namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Editor objects that represents a collection of users or groups of users who have been given specific permissions to edit portions of a document.
/// </summary>
public partial interface Editors : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  public int Count { get; }
}
