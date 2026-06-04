namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of hyperlink.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoHyperlinkType))]
public enum HyperlinkType
{
  /// <summary>
  /// Hyperlink applies to a Range object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoHyperlinkType.msoHyperlinkRange))]
  Range,
  /// <summary>
  /// Hyperlink applies to a Shape object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoHyperlinkType.msoHyperlinkShape))]
  Shape,
  /// <summary>
  /// Hyperlink applies to an inline shape. Used only with Microsoft Word.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoHyperlinkType.msoHyperlinkInlineShape))]
  InlineShape
}
