namespace DocumentModel.Interop;

/// <summary>
/// Provides the primary entry point to the co-authoring object model.
/// </summary>
public interface CoAuthoring : InteropObject
{
  /// <summary>
  /// The authors.
  /// </summary>
  public CoAuthors Authors { get; }
  /// <summary>
  /// The me.
  /// </summary>
  public CoAuthor Me { get; }
  /// <summary>
  /// The pending updates.
  /// </summary>
  public bool PendingUpdates { get; }
  /// <summary>
  /// The locks.
  /// </summary>
  public CoAuthLocks Locks { get; }
  /// <summary>
  /// The updates.
  /// </summary>
  public CoAuthUpdates Updates { get; }
  /// <summary>
  /// The conflicts.
  /// </summary>
  public Conflicts Conflicts { get; }
  /// <summary>
  /// The can share.
  /// </summary>
  public bool CanShare { get; }
  /// <summary>
  /// The can merge.
  /// </summary>
  public bool CanMerge { get; }

}
