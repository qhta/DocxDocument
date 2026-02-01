namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableRowAlignmentValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableRowAlignmentValues))]
public enum TableRowAlignmentKind
{
  /// <summary>
  ///   left.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableRowAlignmentValues.Left))]
  Left,
  /// <summary>
  ///   center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableRowAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   right.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableRowAlignmentValues.Right))]
  Right
}