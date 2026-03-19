namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a repeating section item in a content control.
/// </summary>
public partial interface RepeatingSectionItem : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }
}
