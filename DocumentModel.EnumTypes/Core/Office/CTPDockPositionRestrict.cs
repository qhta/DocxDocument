namespace DocumentModel.Drawings;

/// <summary>
/// Specifies retrictions on the docking behavior of the custom task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoctpdockpositionrestrict?view=office-pia` for Office interop details.
/// </remarks>
public enum CTPDockPositionRestrict
{
  /// <summary>
  /// No restrictions on docking the task pane.
  /// </summary>
  None,
  /// <summary>
  /// There is no change from the current restriction setting for the task pane.
  /// </summary>
  Change,
  /// <summary>
  /// Task pane can't be docked to either the right or the left side of the document window.
  /// </summary>
  Horizontal,
  /// <summary>
  /// Task pane can't be docked to either the top or the bottom of the document window.
  /// </summary>
  Vertical
}
