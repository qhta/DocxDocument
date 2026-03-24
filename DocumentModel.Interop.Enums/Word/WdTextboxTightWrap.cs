namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word tightly wraps text around text boxes.
/// </summary>
public enum WdTextboxTightWrap
{
  /// <summary>
  /// Does not wrap text tightly around the contents of a text box.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Wraps text around the text box tightly to the contents of the text box on all lines. wdTightFirstAndLastLines2
  /// Wraps text tightly only on first and last lines. wdTightFirstLineOnly3 Wraps text tightly only on the first
  /// line. wdTightLastLineOnly4 Wraps text tightly only on the last line.
  /// </summary>
  All = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Office Word tightly wraps text around text boxes.
  /// </summary>
  FirstAndLastLines = unchecked((int)2),
  /// <summary>
  /// Specifies how Microsoft Office Word tightly wraps text around text boxes.
  /// </summary>
  FirstLineOnly = unchecked((int)3),
  /// <summary>
  /// Specifies how Microsoft Office Word tightly wraps text around text boxes.
  /// </summary>
  LastLineOnly = unchecked((int)4)
}
