namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word tightly wraps text around text boxes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextboxtightwrap?view=office-pia` for Office interop details.
/// </remarks>
public enum TextboxTightWrap
{
  /// <summary>
  /// Does not wrap text tightly around the contents of a text box.
  /// </summary>
  None = 0,
  /// <summary>
  /// Wraps text around the text box tightly to the contents of the text box on all lines.
  /// </summary>
  All = 1,
  /// <summary>
  /// Wraps text tightly only on first and last lines.
  /// </summary>
  FirstAndLastLines = 2,
  /// <summary>
  /// Wraps text tightly only on the first line.
  /// </summary>
  FirstLineOnly = 3,
  /// <summary>
  /// Wraps text tightly only on the last line.
  /// </summary>
  LastLineOnly = 4
}
