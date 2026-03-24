namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
public enum WdOrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  Styles = unchecked((int)0),
  /// <summary>
  /// An AutoText item.
  /// </summary>
  AutoText = unchecked((int)1),
  /// <summary>
  /// A command bar item.
  /// </summary>
  CommandBars = unchecked((int)2),
  /// <summary>
  /// A project item.
  /// </summary>
  ProjectItems = unchecked((int)3)
}
