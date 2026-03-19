namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the author of an e-mail message.
/// </summary>
public interface EmailAuthor : InteropObject
{
  /// <summary>
  /// The style.
  /// </summary>
  public Style Style { get; }

}
