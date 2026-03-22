namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies retrictions on the docking behavior of the custom task pane.
/// </summary>
public enum MsoCTPDockPositionRestrict
{
  /// <summary>
  /// No restrictions on docking the task pane. msoCTPDockPositionRestrictNoChange1 There is no change from the
  /// current restriction setting for the task pane. msoCTPDockPositionRestrictNoHorizontal2 Task pane can't be
  /// docked to either the right or the left side of the document window.
  /// </summary>
  msoCTPDockPositionRestrictNone,
  /// <summary>
  /// Specifies retrictions on the docking behavior of the custom task pane.
  /// </summary>
  msoCTPDockPositionRestrictNoChange,
  /// <summary>
  /// Specifies retrictions on the docking behavior of the custom task pane.
  /// </summary>
  msoCTPDockPositionRestrictNoHorizontal,
  /// <summary>
  /// Task pane can't be docked to either the top or the bottom of the document window.
  /// </summary>
  msoCTPDockPositionRestrictNoVertical
}
