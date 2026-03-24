namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates how to sort styles in the Styles task pane.
/// </summary>
public enum WdStyleSort
{
  /// <summary>
  /// Sorts styles alphabetically based on the name of the style. wdStyleSortRecommended1 Sorts styles based on
  /// whether they are recommended for use.
  /// </summary>
  ByName = unchecked((int)0),
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  Recommended = unchecked((int)1),
  /// <summary>
  /// Sorts styles based on the name of the font used. wdStyleSortByBasedOn3 Sorts styles based on the item
  /// indicated in the Sort Styles Based On option.
  /// </summary>
  ByFont = unchecked((int)2),
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByBasedOn = unchecked((int)3),
  /// <summary>
  /// Sorts styles based on whether the style is a paragraph style or character style.
  /// </summary>
  ByType = unchecked((int)4)
}
