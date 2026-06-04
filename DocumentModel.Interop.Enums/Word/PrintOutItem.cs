namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the item to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutitem?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPrintOutItem")]
public enum PrintOutItem
{
  /// <summary>
  /// Current document content.
  /// </summary>
  [WordInteropEnumValue("wdPrintDocumentContent")]
  DocumentContent = 0,
  /// <summary>
  /// Properties in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintProperties")]
  Properties = 1,
  /// <summary>
  /// Comments in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintComments")]
  Comments = 2,
  /// <summary>
  /// Markup in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintMarkup")]
  Markup = 2,
  /// <summary>
  /// Styles in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintStyles")]
  Styles = 3,
  /// <summary>
  /// Autotext entries in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintAutoTextEntries")]
  AutoTextEntries = 4,
  /// <summary>
  /// Key assignments in the current document.
  /// </summary>
  [WordInteropEnumValue("wdPrintKeyAssignments")]
  KeyAssignments = 5,
  /// <summary>
  /// An envelope.
  /// </summary>
  [WordInteropEnumValue("wdPrintEnvelope")]
  Envelope = 6,
  /// <summary>
  /// Current document content including markup.
  /// </summary>
  [WordInteropEnumValue("wdPrintDocumentWithMarkup")]
  DocumentWithMarkup = 7
}
