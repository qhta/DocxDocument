namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues))]
public enum VerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues.Top))]
  Top = 1,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  /// Indicates that the element is located inside the specified boundary or region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues.Inside))]
  Inside,
  /// <summary>
  /// Indicates that the element is positioned outside the defined area or boundary.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignmentValues.Outside))]
  Outside,
}

