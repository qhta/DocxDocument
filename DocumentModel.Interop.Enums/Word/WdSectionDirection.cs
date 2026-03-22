namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word displays the reading order and alignment for the specified sections.
/// </summary>
public enum WdSectionDirection
{
  /// <summary>
  /// Specifies how Word displays the reading order and alignment for the specified sections.
  /// </summary>
  wdSectionDirectionRtl = unchecked((int)0),
  /// <summary>
  /// Displays the section with left alignment and left-to-right reading order.
  /// </summary>
  wdSectionDirectionLtr = unchecked((int)1)
}
