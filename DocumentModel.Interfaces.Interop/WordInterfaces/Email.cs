namespace DocumentModel.Interop;

/// <summary>
/// Represents an e-mail message.
/// </summary>
public interface Email : InteropObject
{
  /// <summary>
  /// The current email author.
  /// </summary>
  public EmailAuthor CurrentEmailAuthor { get; }

}
