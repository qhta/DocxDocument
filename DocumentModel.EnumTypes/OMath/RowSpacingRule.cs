namespace DocumentModel.Math;
/// <summary>
/// Enum type defined basing on RowSpacingRule element.
/// </summary>
[OpenXmlType(typeof(DXM.RowSpacingRule))]
public enum RowSpacingRule
{
  /// <summary>
  /// Sigle line height
  /// </summary>
  [OpenXmlEnumValue(0)]
  Single = 0,
  /// <summary>
  /// One and half of line height
  /// </summary>
  [OpenXmlEnumValue(1)]
  OneAndHalf =1,
  /// <summary>
  /// Double line height
  /// </summary>
  [OpenXmlEnumValue(2)] 
  Double = 2,
  /// <summary>
  /// Exact value of point set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(3)]
  Exactly = 3,
  /// <summary>
  /// Multiple number of half-lines set by RowSpacing
  /// </summary>
  [OpenXmlEnumValue(4)]
  Multiple = 4,
}
