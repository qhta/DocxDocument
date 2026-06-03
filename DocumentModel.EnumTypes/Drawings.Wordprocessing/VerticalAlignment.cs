namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
[OpenXmlEnumType(typeof(DXDW.VerticalAlignmentValues))]
public enum VerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXDW.VerticalAlignmentValues.Top))]
  Top = 1,
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXDW.VerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXDW.VerticalAlignmentValues.Bottom))]
  Bottom,
  /// <summary>
  /// Indicates Ithat the element is located inside the specified boundary or region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXDW.VerticalAlignmentValues.Inside))]
  Inside,
  /// <summary>
  /// Indicates Ithat the element is positioned outside the defined area or boundary.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXDW.VerticalAlignmentValues.Outside))]
  Outside,
}

