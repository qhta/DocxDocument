namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to associate a style sheet with the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesheetlinktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdStyleSheetLinkType))]
public enum StyleSheetLinkType
{
  /// <summary>
  /// Linked external style sheet.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetLinkType.wdStyleSheetLinkTypeLinked))]
  Linked = 0,
  /// <summary>
  /// Imported internal style sheet.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleSheetLinkType.wdStyleSheetLinkTypeImported))]
  Imported = 1
}
