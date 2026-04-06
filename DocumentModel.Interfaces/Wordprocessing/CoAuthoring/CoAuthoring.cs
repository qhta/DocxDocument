namespace DocumentModel.Wordprocessing;

/// <summary>
/// Provides the primary entry point to the co-authoring object model.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring?view=word-pia"/>
public interface ICoAuthoring : IModelObject
{
  /// <summary>
  /// Gets the collection of co-authors currently editing the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.authors?view=word-pia"/>
  public ICoAuthors Authors { get; }
  /// <summary>
  /// Gets the co-author object that represents the current user.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.me?view=word-pia"/>
  public ICoAuthor Me { get; }
  /// <summary>
  /// Gets a value indicating whether there are pending coauthoring updates.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.pendingupdates?view=word-pia"/>
  public bool PendingUpdates { get; }
  /// <summary>
  /// Gets the collection of coauthoring locks in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.locks?view=word-pia"/>
  public ICoAuthLocks Locks { get; }
  /// <summary>
  /// Gets the collection of coauthoring updates.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.updates?view=word-pia"/>
  public ICoAuthUpdates Updates { get; }
  /// <summary>
  /// Gets the collection of coauthoring conflicts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.conflicts?view=word-pia"/>
  public IConflicts Conflicts { get; }
  /// <summary>
  /// Gets a value indicating whether the document can be shared for coauthoring.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canshare?view=word-pia"/>
  public bool CanShare { get; }
  /// <summary>
  /// Gets a value indicating whether coauthoring changes can be merged.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthoring.canmerge?view=word-pia"/>
  public bool CanMerge { get; }

}
