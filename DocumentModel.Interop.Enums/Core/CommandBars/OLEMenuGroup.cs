namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the menu group that a command bar pop-up control belongs to when the menu groups of the OLE server
/// are merged with the menu groups of an OLE client (that is, when an object of the container application type is
/// embedded in another application).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoolemenugroup?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoOLEMenuGroup")]
public enum OLEMenuGroup
{
  /// <summary>
  /// Pop-up control is not merged.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupNone")]
  None = -1,
  /// <summary>
  /// File menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupFile")]
  File,
  /// <summary>
  /// Edit menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupEdit")]
  Edit,
  /// <summary>
  /// Container menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupContainer")]
  Container,
  /// <summary>
  /// Object menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupObject")]
  Object,
  /// <summary>
  /// Window menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupWindow")]
  Window,
  /// <summary>
  /// Help menu.
  /// </summary>
  [InteropEnumValue("msoOLEMenuGroupHelp")]
  Help
}
