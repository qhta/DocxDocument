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
  None = -1,
  /// <summary>
  /// File menu.
  /// </summary>
  File,
  /// <summary>
  /// Edit menu.
  /// </summary>
  Edit,
  /// <summary>
  /// Container menu.
  /// </summary>
  Container,
  /// <summary>
  /// Object menu.
  /// </summary>
  Object,
  /// <summary>
  /// Window menu.
  /// </summary>
  Window,
  /// <summary>
  /// Help menu.
  /// </summary>
  Help
}
