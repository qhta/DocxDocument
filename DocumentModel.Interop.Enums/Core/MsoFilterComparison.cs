namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how the Column and CompareTo properties are compared for an ODSOFilter object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiltercomparison?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFilterComparison))]
public enum FilterComparison
{
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is the same as the Column value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonEqual))]
  Equal,
  /// <summary>
  /// Column matches CompareTo if the CompareTo value is not equal to the Column value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonNotEqual))]
  NotEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonLessThan))]
  LessThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonGreaterThan))]
  GreaterThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than or equal to the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonLessThanEqual))]
  LessThanEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than or equal to the CompareTo value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonGreaterThanEqual))]
  GreaterThanEqual,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonIsBlank))]
  IsBlank,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonIsNotBlank))]
  IsNotBlank,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is contained in the Column value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonContains))]
  Contains,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is not contained in the Column value.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterComparison.msoFilterComparisonNotContains))]
  NotContains
}
