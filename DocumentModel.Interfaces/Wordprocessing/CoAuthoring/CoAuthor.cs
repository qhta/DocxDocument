namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single co-author in the document. The CoAuthor object is a member of the CoAuthors collection. The CoAuthors collection contains all the co-authors in the document (authors that are actively editing the document).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor?view=word-pia"/>
public interface ICoAuthor : IModelObject
{
  /// <summary>
  /// Gets the unique identifier of the co-author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.id?view=word-pia"/>
  public string ID { get; }
  /// <summary>
  /// Gets the display name of the co-author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets a value indicating whether this co-author represents the current user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.isme?view=word-pia"/>
  public bool IsMe { get; }
  /// <summary>
  /// Gets the collection of coauthoring locks owned by this co-author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.locks?view=word-pia"/>
  public ICoAuthLocks Locks { get; }
  /// <summary>
  /// Gets the email address of the co-author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthor.emailaddress?view=word-pia"/>
  public string EmailAddress { get; }

}
