namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of hyperlink.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoHyperlinkType")]
public enum HyperlinkType
{
  /// <summary>
  /// Hyperlink applies to a Range object.
  /// </summary>
  [InteropEnumValue("msoHyperlinkRange")]
  Range,
  /// <summary>
  /// Hyperlink applies to a Shape object.
  /// </summary>
  [InteropEnumValue("msoHyperlinkShape")]
  Shape,
  /// <summary>
  /// Hyperlink applies to an inline shape. Used only with Microsoft Word.
  /// </summary>
  [InteropEnumValue("msoHyperlinkInlineShape")]
  InlineShape
}
