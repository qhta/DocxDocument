namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how Microsoft Office Word tightly wraps text around text boxes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtextboxtightwrap?view=office-pia` for Office interop details.
/// </remarks>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues))]
public enum TextBoxTightWrap
{
  /// <summary>
  /// Does not wrap text tightly around the contents of a text box.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues.None))]
  None = 0,
  /// <summary>
  /// Wraps text around the text box tightly to the contents of the text box on all lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues.AllLines))]
  AllLines = 1,
  /// <summary>
  /// Wraps text tightly only on first and last lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues.FirstAndLastLine))] 
  FirstAndLastLine = 2,
  /// <summary>
  /// Wraps text tightly only on the first line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues.FirstLineOnly))]
  FirstLineOnly = 3,
  /// <summary>
  /// Wraps text tightly only on the last line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TextBoxTightWrapValues.LastLineOnly))]
  LastLineOnly = 4
}
