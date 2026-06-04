namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiltercomparison?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFilterComparison")]
public enum FilterComparison
{
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is the same as the Column value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonEqual")]
  Equal,
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is not equal to the Column value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonNotEqual")]
  NotEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonLessThan")]
  LessThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonGreaterThan")]
  GreaterThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than or equal to the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonLessThanEqual")]
  LessThanEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than or equal to the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonGreaterThanEqual")]
  GreaterThanEqual,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonIsBlank")]
  IsBlank,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonIsNotBlank")]
  IsNotBlank,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is contained in the Column value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonContains")]
  Contains,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is not contained in the Column value.
  /// </summary>
  [OfficeInteropEnumValue("msoFilterComparisonNotContains")]
  NotContains
}
