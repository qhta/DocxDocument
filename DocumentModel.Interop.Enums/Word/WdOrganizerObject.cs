namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
public enum WdOrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  wdOrganizerObjectStyles = unchecked((int)0),
  /// <summary>
  /// An AutoText item.
  /// </summary>
  wdOrganizerObjectAutoText = unchecked((int)1),
  /// <summary>
  /// A command bar item.
  /// </summary>
  wdOrganizerObjectCommandBars = unchecked((int)2),
  /// <summary>
  /// A project item.
  /// </summary>
  wdOrganizerObjectProjectItems = unchecked((int)3)
}
