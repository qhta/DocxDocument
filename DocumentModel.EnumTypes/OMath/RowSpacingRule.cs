namespace DocumentModel.Math;
/// <summary>
/// Enum type defined basing on RowSpacingRule element.
/// </summary>
[OpenXmlType(typeof(DXM.RowSpacingRule))]
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOMathVertAlignType))]
public enum RowSpacingRule
{
  /// <summary>
  /// Sigle line height
  /// </summary>
  [OpenXmlEnumValue(0)]
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingSingle))]
  Single = 0,
  /// <summary>
  /// One and half of line height
  /// </summary>
  [OpenXmlEnumValue(1)]
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacing1pt5))]
  OneAndHalf =1,
  /// <summary>
  /// Double line height
  /// </summary>
  [OpenXmlEnumValue(2)]
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingDouble))]
  Double = 2,
  /// <summary>
  /// Exact value of point set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(3)]
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingExactly))]
  Exactly = 3,
  /// <summary>
  /// Multiple number of half-lines set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(4)]
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOMathSpacingRule.wdOMathSpacingMultiple))]
  Multiple = 4,
}
