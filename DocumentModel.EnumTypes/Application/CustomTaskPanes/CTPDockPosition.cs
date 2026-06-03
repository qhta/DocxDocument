namespace DocumentModel.Application;

/// <summary>
/// Specifies the docking behavior of the custom task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoctpdockposition?view=office-pia` for Office interop details.
/// </remarks>
public enum CTPDockPosition
{
  /// <summary>
  /// Dock the task pane on the left side of the document window.
  /// </summary>
  Left,
  /// <summary>
  /// Dock the task pane at the top of the document window.
  /// </summary>
  Top,
  /// <summary>
  /// Dock the task pane on the right side of the document window.
  /// </summary>
  Right,
  /// <summary>
  /// Dock the task pane at the bottom of the document window.
  /// </summary>
  Bottom,
  /// <summary>
  /// Don't dock the task pane.
  /// </summary>
  Floating
}

