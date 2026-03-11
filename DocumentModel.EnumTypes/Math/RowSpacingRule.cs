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
  Single = 0,
  /// <summary>
  /// One and half of line height
  /// </summary>
  OneAndHalf =1,
  /// <summary>
  /// Double line height
  /// </summary>
  Double = 2,
  /// <summary>
  /// Exact value of point set by RowSpacing
  /// </summary>
  Exactly = 3,
  /// <summary>
  /// Multiple number of half-lines set by RowSpacing
  /// </summary>
  Multiple = 4,
}
