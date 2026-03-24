namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
public enum WdOrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  Styles = 0,
  /// <summary>
  /// An AutoText item.
  /// </summary>
  AutoText = 1,
  /// <summary>
  /// A command bar item.
  /// </summary>
  CommandBars = 2,
  /// <summary>
  /// A project item.
  /// </summary>
  ProjectItems = 3
}
