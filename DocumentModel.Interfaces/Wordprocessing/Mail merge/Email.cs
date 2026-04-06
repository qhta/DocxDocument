namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an e-mail message.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.email?view=word-pia"/>
public interface IEmail : IModelObject
{
  /// <summary>
  /// Gets the current email author.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.email.currentemailauthor?view=word-pia"/>
  public IEmailAuthor CurrentEmailAuthor { get; }

}
