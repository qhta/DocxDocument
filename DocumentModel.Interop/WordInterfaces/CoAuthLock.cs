namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a lock within the document. The CoAuthLock object is a member of the CoAuthLocks collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock?view=word-pia"/>
public partial interface CoAuthLock : InteropObject
{
  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.type?view=word-pia"/>
  public WdLockType Type { get; }

  /// <summary>
  /// The owner.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.owner?view=word-pia"/>
  public CoAuthor Owner { get; }

  /// <summary>
  /// The range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The header footer.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthlock.headerfooter?view=word-pia"/>
  public bool HeaderFooter { get; }
}
