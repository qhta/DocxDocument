namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to sort styles in the Styles task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstylesort?view=office-pia` for Office interop details.
/// </remarks>
public enum WdStyleSort
{
  /// <summary>
  /// Sorts styles alphabetically based on the name of the style. wdStyleSortRecommended1 Sorts styles based on
  /// whether they are recommended for use.
  /// </summary>
  ByName = 0,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  Recommended = 1,
  /// <summary>
  /// Sorts styles based on the name of the font used. wdStyleSortByBasedOn3 Sorts styles based on the item
  /// indicated in the Sort Styles Based On option.
  /// </summary>
  ByFont = 2,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByBasedOn = 3,
  /// <summary>
  /// Sorts styles based on whether the style is a paragraph style or character style.
  /// </summary>
  ByType = 4
}
