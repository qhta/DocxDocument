namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the state of the current document window or task window.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwindowstate?view=office-pia` for Office interop details.
/// </remarks>
public enum WindowState
{
  /// <summary>
  /// Normal.
  /// </summary>
  Normal = 0,
  /// <summary>
  /// Maximized.
  /// </summary>
  Maximize = 1,
  /// <summary>
  /// Minimized.
  /// </summary>
  Minimize = 2
}
