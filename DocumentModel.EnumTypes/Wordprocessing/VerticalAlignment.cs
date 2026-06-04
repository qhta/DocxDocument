namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of vertical alignment of tables and frames.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdverticalalignment?view=office-pia` for Office interop details.
/// </remarks>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues))]
public enum VerticalAlignment
{
  Inline = 0,
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues.Top))]
  Top = 1,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  /// Indicates that the element is located inside the specified boundary or region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues.Inside))]
  Inside,
  /// <summary>
  /// Indicates that the element is positioned outside the defined area or boundary.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues.Outside))]
  Outside,
}
