namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiltercomparison?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoFilterComparison
{
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is the same as the Column value.
  /// </summary>
  Equal,
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is not equal to the Column value.
  /// </summary>
  NotEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than the CompareTo value. msoFilterComparisonGreaterThan3
  /// Column matches CompareTo if the Column value is greater than the CompareTo value.
  /// msoFilterComparisonLessThanEqual4 Column matches CompareTo if the Column value is less than or equal to the
  /// CompareTo value. msoFilterComparisonGreaterThanEqual5 Column matches CompareTo if the Column value is greater
  /// than or equal to the CompareTo value.
  /// </summary>
  LessThan,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  GreaterThan,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  LessThanEqual,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  GreaterThanEqual,
  /// <summary>
  /// Column passes filter if Column is blank. msoFilterComparisonIsNotBlank7 Column passes filter if Column is
  /// blank.
  /// </summary>
  IsBlank,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  IsNotBlank,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is contained in the Column value. public enum
  /// class MsoFilterComparison ﾉ Expand table msoFilterComparisonNotContains9 Column matches CompareTo if any part
  /// of the CompareTo string is not contained in the Column value.
  /// </summary>
  Contains,
  /// <summary>
  /// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
  /// </summary>
  NotContains
}
