namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the item to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutitem?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdPrintOutItem")]
public enum PrintOutItem
{
  /// <summary>
  /// Current document content.
  /// </summary>
  [InteropEnumValue("wdPrintDocumentContent")]
  DocumentContent = 0,
  /// <summary>
  /// Properties in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintProperties")]
  Properties = 1,
  /// <summary>
  /// Comments in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintComments")]
  Comments = 2,
  /// <summary>
  /// Markup in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintMarkup")]
  Markup = 2,
  /// <summary>
  /// Styles in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintStyles")]
  Styles = 3,
  /// <summary>
  /// Autotext entries in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintAutoTextEntries")]
  AutoTextEntries = 4,
  /// <summary>
  /// Key assignments in the current document.
  /// </summary>
  [InteropEnumValue("wdPrintKeyAssignments")]
  KeyAssignments = 5,
  /// <summary>
  /// An envelope.
  /// </summary>
  [InteropEnumValue("wdPrintEnvelope")]
  Envelope = 6,
  /// <summary>
  /// Current document content including markup.
  /// </summary>
  [InteropEnumValue("wdPrintDocumentWithMarkup")]
  DocumentWithMarkup = 7
}
