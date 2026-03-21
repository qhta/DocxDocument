namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an e-mail message.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.email?view=word-pia"/>
public interface Email : InteropObject
{
  /// <summary>
  /// The current email author.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.email.currentemailauthor?view=word-pia"/>
  public EmailAuthor CurrentEmailAuthor { get; }

}
