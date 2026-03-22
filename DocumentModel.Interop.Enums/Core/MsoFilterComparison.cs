namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
/// </summary>
public enum MsoFilterComparison
{
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is the same as the Column value.
  /// </summary>
  msoFilterComparisonEqual,
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is not equal to the Column value.
  /// </summary>
  msoFilterComparisonNotEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than the CompareTo value. msoFilterComparisonGreaterThan3
  /// Column matches CompareTo if the Column value is greater than the CompareTo value.
  /// msoFilterComparisonLessThanEqual4 Column matches CompareTo if the Column value is less than or equal to the
  /// CompareTo value. msoFilterComparisonGreaterThanEqual5 Column matches CompareTo if the Column value is greater
  /// than or equal to the CompareTo value.
  /// </summary>
  msoFilterComparisonLessThan,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  msoFilterComparisonGreaterThan,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  msoFilterComparisonLessThanEqual,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  msoFilterComparisonGreaterThanEqual,
  /// <summary>
  /// Column passes filter if Column is blank. msoFilterComparisonIsNotBlank7 Column passes filter if Column is
  /// blank.
  /// </summary>
  msoFilterComparisonIsBlank,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  msoFilterComparisonIsNotBlank,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is contained in the Column value. public enum
  /// class MsoFilterComparison ﾉ Expand table msoFilterComparisonNotContains9 Column matches CompareTo if any part
  /// of the CompareTo string is not contained in the Column value.
  /// </summary>
  msoFilterComparisonContains,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  msoFilterComparisonNotContains
}
