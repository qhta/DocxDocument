namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word tightly wraps text around text boxes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextboxtightwrap?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTextboxTightWrap")]
public enum TextboxTightWrap
{
  /// <summary>
  /// Does not wrap text tightly around the contents of a text box.
  /// </summary>
  [InteropEnumValue("wdTightNone")]
  None = 0,
  /// <summary>
  /// Wraps text around the text box tightly to the contents of the text box on all lines.
  /// </summary>
  [InteropEnumValue("wdTightAll")]
  All = 1,
  /// <summary>
  /// Wraps text tightly only on first and last lines.
  /// </summary>
  [InteropEnumValue("wdTightFirstAndLastLines")]
  FirstAndLastLines = 2,
  /// <summary>
  /// Wraps text tightly only on the first line.
  /// </summary>
  [InteropEnumValue("wdTightFirstLineOnly")]
  FirstLineOnly = 3,
  /// <summary>
  /// Wraps text tightly only on the last line.
  /// </summary>
  [InteropEnumValue("wdTightLastLineOnly")]
  LastLineOnly = 4
}
