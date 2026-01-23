namespace DocumentModel.Math;
/// <summary>
/// Enum type defined basing on RowSpacingRule element.
/// </summary>
public enum RowSpacingRuleKind
{
  /// <summary>
  /// Sigle line height
  /// </summary>
  Single,
  /// <summary>
  /// One and half of line height
  /// </summary>
  OneAndHalf,
  /// <summary>
  /// Double line height
  /// </summary>
  Double,
  /// <summary>
  /// Exact value of point set by RowSpacing
  /// </summary>
  Exactly,
  /// <summary>
  /// Multiple number of half-lines set by RowSpacing
  /// </summary>
  Multiple,
}
