namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides the primary entry point to the co-authoring object model.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring?view=word-pia"/>
public interface ICoAuthoring : IInteropObject
{
  /// <summary>
  /// Gets the collection of co-authors currently editing the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.authors?view=word-pia"/>
  public CoAuthors Authors { get; }
  /// <summary>
  /// Gets the co-author object that represents the current user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.me?view=word-pia"/>
  public CoAuthor Me { get; }
  /// <summary>
  /// Gets a value indicating whether there are pending coauthoring updates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.pendingupdates?view=word-pia"/>
  public bool PendingUpdates { get; }
  /// <summary>
  /// Gets the collection of coauthoring locks in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }
  /// <summary>
  /// Gets the collection of coauthoring updates.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.updates?view=word-pia"/>
  public CoAuthUpdates Updates { get; }
  /// <summary>
  /// Gets the collection of coauthoring conflicts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.conflicts?view=word-pia"/>
  public Conflicts Conflicts { get; }
  /// <summary>
  /// Gets a value indicating whether the document can be shared for coauthoring.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canshare?view=word-pia"/>
  public bool CanShare { get; }
  /// <summary>
  /// Gets a value indicating whether coauthoring changes can be merged.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canmerge?view=word-pia"/>
  public bool CanMerge { get; }

}
