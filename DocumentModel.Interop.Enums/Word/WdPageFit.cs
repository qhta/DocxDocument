namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view setting for a page.
/// </summary>
public enum WdPageFit
{
  /// <summary>
  /// Do not adjust the view settings for the page.
  /// </summary>
  wdPageFitNone = unchecked((int)0),
  /// <summary>
  /// View the full page.
  /// </summary>
  wdPageFitFullPage = unchecked((int)1),
  /// <summary>
  /// Best fit the page to the current window.
  /// </summary>
  wdPageFitBestFit = unchecked((int)2),
  /// <summary>
  /// Best fit the text of the page to the current window.
  /// </summary>
  wdPageFitTextFit = unchecked((int)3)
}
