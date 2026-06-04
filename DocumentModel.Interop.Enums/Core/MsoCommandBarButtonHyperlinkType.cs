namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the command bar button is a hyperlink. If the command bar button is a hyperlink, further
/// specifies whether the hyperlink should launch another application such as the browser or insert a picture at
/// the active selection point.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocommandbarbuttonhyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCommandBarButtonHyperlinkType))]
public enum CommandBarButtonHyperlinkType
{
  /// <summary>
  /// The command bar button is not a hyperlink.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCommandBarButtonHyperlinkType.msoCommandBarButtonHyperlinkNone))]
  None,
  /// <summary>
  /// Clicking the command bar button opens the link specified in the command bar button's TooltipText property.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCommandBarButtonHyperlinkType.msoCommandBarButtonHyperlinkOpen))]
  Open,
  /// <summary>
  /// Clicking the command bar button inserts a picture at the active selection point.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCommandBarButtonHyperlinkType.msoCommandBarButtonHyperlinkInsertPicture))]
  InsertPicture
}
