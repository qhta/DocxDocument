namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlocks?view=word-pia"/>
public partial interface ICoAuthLocks: IModelObject
{
  /// <summary>
  /// Adds a co-authoring lock for the specified range and lock type.
  /// </summary>
  /// <param name="Range">The range to lock.</param>
  /// <param name="Type">The lock type to apply.</param>
  /// <returns>The created <see cref="ICoAuthLock"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlocks.add?view=word-pia"/>
  public ICoAuthLock Add(object Range, LockType Type);

  /// <summary>
  /// Removes ephemeral locks from the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlocks.removeephemerallocks?view=word-pia"/>
  public void RemoveEphemeralLocks();
}
