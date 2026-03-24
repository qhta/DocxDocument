namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the category axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlcategorytype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlCategoryType
{
  /// <summary>
  /// Axis groups data by an arbitrary set of categories.
  /// </summary>
  CategoryScale = 2,
  /// <summary>
  /// Axis groups data on a time scale.
  /// </summary>
  TimeScale = 3,
  /// <summary>
  /// Specifies the type of the category axis.
  /// </summary>
  AutomaticScale = -4105
}
