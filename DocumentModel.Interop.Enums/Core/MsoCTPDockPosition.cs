namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the docking behavior of the custom task pane.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoctpdockposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCTPDockPosition))]
public enum CTPDockPosition
{
  /// <summary>
  /// Dock the task pane on the left side of the document window.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft))]
  Left,
  /// <summary>
  /// Dock the task pane at the top of the document window.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionTop))]
  Top,
  /// <summary>
  /// Dock the task pane on the right side of the document window.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight))]
  Right,
  /// <summary>
  /// Dock the task pane at the bottom of the document window.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionBottom))]
  Bottom,
  /// <summary>
  /// Don't dock the task pane.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionFloating))]
  Floating
}
