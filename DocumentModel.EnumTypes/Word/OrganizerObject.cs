namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorganizerobject?view=office-pia` for Office interop details.
/// </remarks>
public enum OrganizerObject
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
