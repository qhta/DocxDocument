namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where a paragraph should be relocated in relation to its current position.
/// </summary>
public enum WdRelocate
{
  /// <summary>
  /// Above the previous visible paragraph.
  /// </summary>
  Up = unchecked((int)0),
  /// <summary>
  /// Below the next visible paragraph.
  /// </summary>
  Down = unchecked((int)1)
}
