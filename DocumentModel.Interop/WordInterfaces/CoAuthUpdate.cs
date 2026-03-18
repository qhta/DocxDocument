namespace DocumentModel.Interop;

/// <summary>
/// Represents a range of text that has been updated by a co-author.
/// </summary>
public interface CoAuthUpdate : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

}
