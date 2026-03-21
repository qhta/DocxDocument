namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides the primary entry point to the co-authoring object model.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring?view=word-pia"/>
public interface CoAuthoring : InteropObject
{
  /// <summary>
  /// The authors.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.authors?view=word-pia"/>
  public CoAuthors Authors { get; }
  /// <summary>
  /// The me.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.me?view=word-pia"/>
  public CoAuthor Me { get; }
  /// <summary>
  /// The pending updates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.pendingupdates?view=word-pia"/>
  public bool PendingUpdates { get; }
  /// <summary>
  /// The locks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }
  /// <summary>
  /// The updates.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.updates?view=word-pia"/>
  public CoAuthUpdates Updates { get; }
  /// <summary>
  /// The conflicts.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.conflicts?view=word-pia"/>
  public Conflicts Conflicts { get; }
  /// <summary>
  /// The can share.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canshare?view=word-pia"/>
  public bool CanShare { get; }
  /// <summary>
  /// The can merge.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canmerge?view=word-pia"/>
  public bool CanMerge { get; }

}
