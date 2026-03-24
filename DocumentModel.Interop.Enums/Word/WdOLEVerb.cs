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
  Primary = 0,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  DiscardUndoState = -6,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  InPlaceActivate = -5,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  UIActivate = -4,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  Hide = -3,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  Open = -2,
  /// <summary>
  /// Specifies the action associated with the verb that the OLE object should perform.
  /// </summary>
  Show = -1
}
