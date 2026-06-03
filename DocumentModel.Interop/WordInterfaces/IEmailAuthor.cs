namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the author of an e-mail message.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailauthor?view=word-pia"/>
public interface IEmailAuthor : IInteropObject
{
  /// <summary>
  /// Gets the style associated with the email author.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailauthor.style?view=word-pia"/>
  public IStyle IStyle { get; }

}
