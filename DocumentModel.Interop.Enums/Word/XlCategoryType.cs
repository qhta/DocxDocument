namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of the category axis.
/// </summary>
public enum XlCategoryType
{
  /// <summary>
  /// Axis groups data by an arbitrary set of categories.
  /// </summary>
  xlCategoryScale = unchecked((int)2),
  /// <summary>
  /// Axis groups data on a time scale.
  /// </summary>
  xlTimeScale = unchecked((int)3),
  /// <summary>
  /// Specifies the type of the category axis.
  /// </summary>
  xlAutomaticScale = unchecked((int)-4105)
}
