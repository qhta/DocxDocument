namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the item to print.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdprintoutitem?view=office-pia` for Office interop details.
/// </remarks>
public enum PrintOutItem
{
  /// <summary>
  /// Current document content.
  /// </summary>
  DocumentContent = 0,
  /// <summary>
  /// Properties in the current document.
  /// </summary>
  Properties = 1,
  /// <summary>
  /// Comments in the current document.
  /// </summary>
  Comments = 2,
  /// <summary>
  /// Markup in the current document.
  /// </summary>
  Markup = 2,
  /// <summary>
  /// Styles in the current document.
  /// </summary>
  Styles = 3,
  /// <summary>
  /// Autotext entries in the current document.
  /// </summary>
  AutoTextEntries = 4,
  /// <summary>
  /// Key assignments in the current document.
  /// </summary>
  KeyAssignments = 5,
  /// <summary>
  /// An envelope.
  /// </summary>
  Envelope = 6,
  /// <summary>
  /// Current document content including markup.
  /// </summary>
  DocumentWithMarkup = 7
}
