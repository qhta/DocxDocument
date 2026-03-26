namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how to associate a style sheet with the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesheetlinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum StyleSheetLinkType
{
  /// <summary>
  /// Linked external style sheet.
  /// </summary>
  Linked = 0,
  /// <summary>
  /// Imported internal style sheet.
  /// </summary>
  Imported = 1
}
