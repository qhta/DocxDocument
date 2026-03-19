namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single e-mail signature entry.
/// </summary>
public partial interface EmailSignatureEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; set; }
}
