namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view setting for a page.
/// </summary>
public enum WdPageFit
{
  /// <summary>
  /// Do not adjust the view settings for the page.
  /// </summary>
  None = 0,
  /// <summary>
  /// View the full page.
  /// </summary>
  FullPage = 1,
  /// <summary>
  /// Best fit the page to the current window.
  /// </summary>
  BestFit = 2,
  /// <summary>
  /// Best fit the text of the page to the current window.
  /// </summary>
  TextFit = 3
}
