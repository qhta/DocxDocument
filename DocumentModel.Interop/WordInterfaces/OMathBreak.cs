namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents individual line breaks in an equation. Each OMathBreak object is a member of the OMathBreaks collection.
/// </summary>
public partial interface OMathBreak : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The align at.
  /// </summary>
  public int AlignAt { get; set; }
}
