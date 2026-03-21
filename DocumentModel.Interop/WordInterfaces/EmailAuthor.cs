namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the author of an e-mail message.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailauthor?view=word-pia"/>
public interface EmailAuthor : InteropObject
{
  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.emailauthor.style?view=word-pia"/>
  public Style Style { get; }

}
