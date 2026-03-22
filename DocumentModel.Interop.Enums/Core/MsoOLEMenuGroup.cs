namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the menu group that a command bar pop-up control belongs to when the menu groups of the OLE server
/// are merged with the menu groups of an OLE client (that is, when an object of the container application type is
/// embedded in another application).
/// </summary>
public enum MsoOLEMenuGroup
{
  /// <summary>
  /// Specifies the menu group that a command bar pop-up control belongs to when the menu groups of the OLE server
  /// are merged with the menu groups of an OLE client (that is, when an object of the container application type is
  /// embedded in another application).
  /// </summary>
  msoOLEMenuGroupNone = -1,
  /// <summary>
  /// File menu.
  /// </summary>
  msoOLEMenuGroupFile,
  /// <summary>
  /// Edit menu.
  /// </summary>
  msoOLEMenuGroupEdit,
  /// <summary>
  /// Container menu.
  /// </summary>
  msoOLEMenuGroupContainer,
  /// <summary>
  /// Object menu.
  /// </summary>
  msoOLEMenuGroupObject,
  /// <summary>
  /// Window menu.
  /// </summary>
  msoOLEMenuGroupWindow,
  /// <summary>
  /// Help menu.
  /// </summary>
  msoOLEMenuGroupHelp
}
