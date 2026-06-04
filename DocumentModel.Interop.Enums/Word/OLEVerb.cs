namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the action associated with the verb that the OLE object should perform.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoleverb?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOLEVerb")]
public enum OLEVerb
{
  /// <summary>
  /// Performs the verb that is invoked when the user double-clicks the object.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbPrimary")]
  Primary = 0,
  /// <summary>
  /// Forces the object to discard any undo state that it might be maintaining; note that the object remains active,
  /// however.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbDiscardUndoState")]
  DiscardUndoState = -6,
  /// <summary>
  /// Runs the object and installs its window, but doesn't install any user-interface tools.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbInPlaceActivate")]
  InPlaceActivate = -5,
  /// <summary>
  /// Activates the object in place and displays any user-interface tools that the object needs, such as menus or
  /// toolbars.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbUIActivate")]
  UIActivate = -4,
  /// <summary>
  /// Removes the object's user interface from view.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbHide")]
  Hide = -3,
  /// <summary>
  /// Opens the object in a separate window.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbOpen")]
  Open = -2,
  /// <summary>
  /// Shows the object to the user for editing or viewing. Use it to show a newly inserted object for initial
  /// editing.
  /// </summary>
  [WordInteropEnumValue("wdOLEVerbShow")]
  Show = -1
}
