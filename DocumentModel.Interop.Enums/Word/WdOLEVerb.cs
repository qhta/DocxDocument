namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the action associated with the verb that the OLE object should perform.
/// </summary>
public enum WdOLEVerb
{
  /// <summary>
  /// Performs the verb that is invoked when the user double-clicks the object.
  /// [System.Runtime.InteropServices.Guid("B1E1E568-A954-370D-BDDE-1DEE3FE965D7")] public enum WdOLEVerb ﾉ Expand
  /// table
  /// </summary>
  wdOLEVerbPrimary = unchecked((int)0),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbDiscardUndoState = unchecked((int)-6),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbInPlaceActivate = unchecked((int)-5),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbUIActivate = unchecked((int)-4),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbHide = unchecked((int)-3),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbOpen = unchecked((int)-2),
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  wdOLEVerbShow = unchecked((int)-1)
}
