namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word tightly wraps text around text boxes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextboxtightwrap?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTextboxTightWrap")]
public enum TextboxTightWrap
{
  /// <summary>
  /// Does not wrap text tightly around the contents of a text box.
  /// </summary>
  [WordInteropEnumValue("wdTightNone")]
  None = 0,
  /// <summary>
  /// Wraps text around the text box tightly to the contents of the text box on all lines.
  /// </summary>
  [WordInteropEnumValue("wdTightAll")]
  All = 1,
  /// <summary>
  /// Wraps text tightly only on first and last lines.
  /// </summary>
  [WordInteropEnumValue("wdTightFirstAndLastLines")]
  FirstAndLastLines = 2,
  /// <summary>
  /// Wraps text tightly only on the first line.
  /// </summary>
  [WordInteropEnumValue("wdTightFirstLineOnly")]
  FirstLineOnly = 3,
  /// <summary>
  /// Wraps text tightly only on the last line.
  /// </summary>
  [WordInteropEnumValue("wdTightLastLineOnly")]
  LastLineOnly = 4
}
