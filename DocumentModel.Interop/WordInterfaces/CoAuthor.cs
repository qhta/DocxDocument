namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single co-author in the document. The CoAuthor object is a member of the CoAuthors collection. The CoAuthors collection contains all the co-authors in the document (authors that are actively editing the document).
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor?view=word-pia"/>
public interface CoAuthor : InteropObject
{
  /// <summary>
  /// The id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.id?view=word-pia"/>
  public string ID { get; }
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// The is me.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.isme?view=word-pia"/>
  public bool IsMe { get; }
  /// <summary>
  /// The locks.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.locks?view=word-pia"/>
  public CoAuthLocks Locks { get; }
  /// <summary>
  /// The email address.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.emailaddress?view=word-pia"/>
  public string EmailAddress { get; }

}
