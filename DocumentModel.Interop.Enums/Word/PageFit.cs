namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the view setting for a page.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdpagefit?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdPageFit")]
public enum PageFit
{
  /// <summary>
  /// Do not adjust the view settings for the page.
  /// </summary>
  [WordInteropEnumValue("wdPageFitNone")]
  None = 0,
  /// <summary>
  /// View the full page.
  /// </summary>
  [WordInteropEnumValue("wdPageFitFullPage")]
  FullPage = 1,
  /// <summary>
  /// Best fit the page to the current window.
  /// </summary>
  [WordInteropEnumValue("wdPageFitBestFit")]
  BestFit = 2,
  /// <summary>
  /// Best fit the text of the page to the current window.
  /// </summary>
  [WordInteropEnumValue("wdPageFitTextFit")]
  TextFit = 3
}
