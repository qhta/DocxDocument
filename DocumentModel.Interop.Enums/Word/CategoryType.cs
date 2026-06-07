namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the category axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.xlcategorytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlCategoryType")]
public enum CategoryType
{
  /// <summary>
  /// Axis groups data by an arbitrary set of categories.
  /// </summary>
  [InteropEnumValue("xlCategoryScale")]
  CategoryScale = 2,
  /// <summary>
  /// Axis groups data on a time scale.
  /// </summary>
  [InteropEnumValue("xlTimeScale")]
  TimeScale = 3,
  /// <summary>
  /// Word controls the axis type.
  /// </summary>
  [InteropEnumValue("xlAutomaticScale")]
  AutomaticScale = -4105
}

