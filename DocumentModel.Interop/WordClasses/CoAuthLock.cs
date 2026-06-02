namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a lock within the document. The CoAuthLock object is a member of the CoAuthLocks collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock?view=word-pia"/>
public partial class CoAuthLock : InteropObject
{
  /// <summary>
  /// Gets the type of coauthoring lock.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.type?view=word-pia"/>
  public LockType Type { get; set; }

  /// <summary>
  /// Gets the coauthor who owns the lock.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.owner?view=word-pia"/>
  public CoAuthor Owner { get; set; }

  /// <summary>
  /// Gets the range in the document covered by the lock.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.range?view=word-pia"/>
  public Range Range { get; set; }

  /// <summary>
  /// Gets a value indicating whether the lock is in a header or footer.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.headerfooter?view=word-pia"/>
  public bool HeaderFooter { get; set; }


  #region methods

/// <summary>
  /// Unlocks the specified lock.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.unlock?view=word-pia"/>
  public void Unlock() { throw new NotImplementedException(); }

  #endregion methods
}
