namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the menu group that a command bar pop-up control belongs to when the menu groups of the OLE server
/// are merged with the menu groups of an OLE client (that is, when an object of the container application type is
/// embedded in another application).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoolemenugroup?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoOLEMenuGroup")]
public enum OLEMenuGroup
{
  /// <summary>
  /// Pop-up control is not merged.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupNone")]
  None = -1,
  /// <summary>
  /// File menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupFile")]
  File,
  /// <summary>
  /// Edit menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupEdit")]
  Edit,
  /// <summary>
  /// Container menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupContainer")]
  Container,
  /// <summary>
  /// Object menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupObject")]
  Object,
  /// <summary>
  /// Window menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupWindow")]
  Window,
  /// <summary>
  /// Help menu.
  /// </summary>
  [OfficeInteropEnumValue("msoOLEMenuGroupHelp")]
  Help
}
