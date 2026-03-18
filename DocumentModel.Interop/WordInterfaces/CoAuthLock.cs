namespace DocumentModel.Interop;

/// <summary>
/// Represents a lock within the document. The CoAuthLock object is a member of the CoAuthLocks collection.
/// </summary>
public partial interface CoAuthLock : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  public WdLockType Type { get; }

  /// <summary>
  /// The owner.
  /// </summary>
  public CoAuthor Owner { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The header footer.
  /// </summary>
  public bool HeaderFooter { get; }
}
