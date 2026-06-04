namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the menu group that a command bar pop-up control belongs to when the menu groups of the OLE server
/// are merged with the menu groups of an OLE client (that is, when an object of the container application type is
/// embedded in another application).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoolemenugroup?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoOLEMenuGroup))]
public enum OLEMenuGroup
{
  /// <summary>
  /// Pop-up control is not merged.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupNone))]
  None = -1,
  /// <summary>
  /// File menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupFile))]
  File,
  /// <summary>
  /// Edit menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupEdit))]
  Edit,
  /// <summary>
  /// Container menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupContainer))]
  Container,
  /// <summary>
  /// Object menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupObject))]
  Object,
  /// <summary>
  /// Window menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupWindow))]
  Window,
  /// <summary>
  /// Help menu.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoOLEMenuGroup.msoOLEMenuGroupHelp))]
  Help
}
