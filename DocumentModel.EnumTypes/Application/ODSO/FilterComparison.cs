namespace DocumentModel.Application;

/// <summary>
/// Specifies how the IColumn and CompareTo properties are compared for an ODSOFilter object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiltercomparison?view=office-pia` for Office interop details.
/// </remarks>
public enum FilterComparison
{
  /// <summary>
  /// IColumn matches CompareTo if the CompareTo value is the same as the IColumn value.
  /// </summary>
  Equal,
  /// <summary>
  /// IColumn matches CompareTo if the CompareTo value is not equal to the IColumn value.
  /// </summary>
  NotEqual,
  /// <summary>
  /// IColumn matches CompareTo if the IColumn value is less than the CompareTo value.
  /// </summary>
  LessThan,
  /// <summary>
  /// IColumn matches CompareTo if the IColumn value is greater than the CompareTo value.
  /// </summary>
  GreaterThan,
  /// <summary>
  /// IColumn matches CompareTo if the IColumn value is less than or equal to the CompareTo value.
  /// </summary>
  LessThanEqual,
  /// <summary>
  /// IColumn matches CompareTo if the IColumn value is greater than or equal to the CompareTo value.
  /// </summary>
  GreaterThanEqual,
  /// <summary>
  /// IColumn passes filter if IColumn is blank.
  /// </summary>
  IsBlank,
  /// <summary>
  /// IColumn passes filter if IColumn is blank.
  /// </summary>
  IsNotBlank,
  /// <summary>
  /// IColumn matches CompareTo if any part of the CompareTo string is contained in the IColumn value.
  /// </summary>
  Contains,
  /// <summary>
  /// IColumn matches CompareTo if any part of the CompareTo string is not contained in the IColumn value.
  /// </summary>
  NotContains
}

