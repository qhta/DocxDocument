namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to associate a style sheet with the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesheetlinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStyleSheetLinkType")]
public enum StyleSheetLinkType
{
  /// <summary>
  /// Linked external style sheet.
  /// </summary>
  [WordInteropEnumValue("wdStyleSheetLinkTypeLinked")]
  Linked = 0,
  /// <summary>
  /// Imported internal style sheet.
  /// </summary>
  [WordInteropEnumValue("wdStyleSheetLinkTypeImported")]
  Imported = 1
}
