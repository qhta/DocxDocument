namespace DocumentModel.Interop;

/// <summary>
/// Represents a single reviewer of a document in which changes have been tracked.
/// </summary>
public interface Reviewer : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }

}
