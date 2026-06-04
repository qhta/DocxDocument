namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to sort styles in the Styles task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesort?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStyleSort")]
public enum StyleSort
{
  /// <summary>
  /// Sorts styles alphabetically based on the name of the style.
  /// </summary>
  [WordInteropEnumValue("wdStyleSortByName")]
  ByName = 0,
  /// <summary>
  /// Sorts styles based on whether they are recommended for use.
  /// </summary>
  [WordInteropEnumValue("wdStyleSortRecommended")]
  Recommended = 1,
  /// <summary>
  /// Sorts styles based on the name of the font used.
  /// </summary>
  [WordInteropEnumValue("wdStyleSortByFont")]
  ByFont = 2,
  /// <summary>
  /// Sorts styles based on the item indicated in the Sort Styles Based On option.
  /// </summary>
  [WordInteropEnumValue("wdStyleSortByBasedOn")]
  ByBasedOn = 3,
  /// <summary>
  /// Sorts styles based on whether the style is a paragraph style or character style.
  /// </summary>
  [WordInteropEnumValue("wdStyleSortByType")]
  ByType = 4
}
