namespace DocumentModel.Interop.Word;

public partial interface EmailSignatureEntries
{
  /// <summary>
  /// Returns the value produced by the add operation.
  /// </summary>
  /// <param name="Name">Specifies the name.</param>
  /// <param name="Range">Specifies the range.</param>
  /// <returns>The resulting value.</returns>
  public EmailSignatureEntry Add(string Name, Range Range);
}
