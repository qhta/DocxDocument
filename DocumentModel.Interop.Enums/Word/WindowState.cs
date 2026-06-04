namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state of the current document window or task window.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwindowstate?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWindowState))]
public enum WindowState
{
  /// <summary>
  /// Normal.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal))]
  Normal = 0,
  /// <summary>
  /// Maximized.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize))]
  Maximize = 1,
  /// <summary>
  /// Minimized.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMinimize))]
  Minimize = 2
}
