namespace DocumentModel.Interop;

/// <summary>
/// Represents a single co-author in the document. The CoAuthor object is a member of the CoAuthors collection. The CoAuthors collection contains all the co-authors in the document (authors that are actively editing the document).
/// </summary>
public interface CoAuthor : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  public string ID { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The is me.
  /// </summary>
  public bool IsMe { get; }
  /// <summary>
  /// The locks.
  /// </summary>
  public CoAuthLocks Locks { get; }
  /// <summary>
  /// The email address.
  /// </summary>
  public string EmailAddress { get; }

}
