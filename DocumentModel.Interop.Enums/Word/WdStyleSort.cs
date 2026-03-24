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
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByName = 0,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  Recommended = 1,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByFont = 2,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByBasedOn = 3,
  /// <summary>
  /// Indicates how to sort styles in the Styles task pane.
  /// </summary>
  ByType = 4
}
