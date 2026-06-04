namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the docking behavior of the custom task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoctpdockposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCTPDockPosition")]
public enum CTPDockPosition
{
  /// <summary>
  /// Dock the task pane on the left side of the document window.
  /// </summary>
  [OfficeInteropEnumValue("msoCTPDockPositionLeft")]
  Left,
  /// <summary>
  /// Dock the task pane at the top of the document window.
  /// </summary>
  [OfficeInteropEnumValue("msoCTPDockPositionTop")]
  Top,
  /// <summary>
  /// Dock the task pane on the right side of the document window.
  /// </summary>
  [OfficeInteropEnumValue("msoCTPDockPositionRight")]
  Right,
  /// <summary>
  /// Dock the task pane at the bottom of the document window.
  /// </summary>
  [OfficeInteropEnumValue("msoCTPDockPositionBottom")]
  Bottom,
  /// <summary>
  /// Don't dock the task pane.
  /// </summary>
  [OfficeInteropEnumValue("msoCTPDockPositionFloating")]
  Floating
}
