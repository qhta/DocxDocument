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
  /// Column matches CompareTo if the Column value is less than the CompareTo value.
  /// </summary>
  LessThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than the CompareTo value.
  /// </summary>
  GreaterThan,
  /// <summary>
  /// Column matches CompareTo if the Column value is less than or equal to the CompareTo value.
  /// </summary>
  LessThanEqual,
  /// <summary>
  /// Column matches CompareTo if the Column value is greater than or equal to the CompareTo value.
  /// </summary>
  GreaterThanEqual,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  IsBlank,
  /// <summary>
  /// Column passes filter if Column is blank.
  /// </summary>
  IsNotBlank,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is contained in the Column value.
  /// </summary>
  Contains,
  /// <summary>
  /// Column matches CompareTo if any part of the CompareTo string is not contained in the Column value.
  /// </summary>
  NotContains
}
