namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableVerticalAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableVerticalAlignmentValues))]
public enum TableVerticalAlignment
{
  /// <summary>
  ///   top.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableVerticalAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableVerticalAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableVerticalAlignmentValues.Bottom))]
  Bottom
}