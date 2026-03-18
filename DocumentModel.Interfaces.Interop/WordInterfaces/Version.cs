namespace DocumentModel.Interop;

/// <summary>
/// Represents a single version of a document.
/// </summary>
public partial interface Version : InteropObject
{
  /// <summary>
  /// The saved by.
  /// </summary>
  public string SavedBy { get; }

  /// <summary>
  /// The comment.
  /// </summary>
  public string Comment { get; }

  /// <summary>
  /// The date.
  /// </summary>
  public DateTime Date { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
}
