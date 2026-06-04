namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the current document window or task window.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwindowstate?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdWindowState")]
public enum WindowState
{
  /// <summary>
  /// Normal.
  /// </summary>
  [WordInteropEnumValue("wdWindowStateNormal")]
  Normal = 0,
  /// <summary>
  /// Maximized.
  /// </summary>
  [WordInteropEnumValue("wdWindowStateMaximize")]
  Maximize = 1,
  /// <summary>
  /// Minimized.
  /// </summary>
  [WordInteropEnumValue("wdWindowStateMinimize")]
  Minimize = 2
}
