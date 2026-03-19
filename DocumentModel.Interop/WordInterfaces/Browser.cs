namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the browser tool used to move the insertion point to objects in a document.
/// </summary>
public partial interface Browser : InteropObject
{
  /// <summary>
  /// The target.
  /// </summary>
  public WdBrowseTarget Target { get; set; }
}
