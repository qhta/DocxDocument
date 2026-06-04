namespace DocumentModel.Math;
/// <summary>
/// Enum type defined basing on RowSpacingRule element.
/// </summary>
[OpenXmlType(typeof(DocumentFormat.OpenXml.Math.RowSpacingRule))]
[InteropEnumType("Microsoft.Office.Interop.Word.WdOMathVertAlignType")]
public enum RowSpacingRule
{
  /// <summary>
  /// Sigle line height
  /// </summary>
  [OpenXmlEnumValue(0)]
  [InteropEnumValue("WdOMathSpacingSingle")]
  Single = 0,
  /// <summary>
  /// One and half of line height
  /// </summary>
  [OpenXmlEnumValue(1)]
  [InteropEnumValue("WdOMathSpacing1pt5")]
  OneAndHalf =1,
  /// <summary>
  /// Double line height
  /// </summary>
  [OpenXmlEnumValue(2)]
  [InteropEnumValue("WdOMathSpacingDouble")]
  Double = 2,
  /// <summary>
  /// Exact value of point set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(3)]
  [InteropEnumValue("WdOMathSpacingExactly")]
  Exactly = 3,
  /// <summary>
  /// Multiple number of half-lines set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(4)]
  [InteropEnumValue("WdOMathSpacingMultiple")]
  Multiple = 4,
}
