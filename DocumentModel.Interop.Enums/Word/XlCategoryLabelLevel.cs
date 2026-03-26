namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent chart category-label levels, passed to and returned by the CategoryLabelLevel
/// property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlcategorylabellevel?view=office-pia` for Office interop details.
/// </remarks>
public enum CategoryLabelLevel
{
  /// <summary>
  /// Use no category labels in the chart. Defaults to automatic indexed labels.
  /// </summary>
  None = -3,
  /// <summary>
  /// Indicates literal data in the category labels.
  /// </summary>
  Custom = -2,
  /// <summary>
  /// Use all category label levels within range on the chart. The default.
  /// </summary>
  All = -1
}
