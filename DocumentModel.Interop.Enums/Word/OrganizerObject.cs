namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorganizerobject?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOrganizerObject")]
public enum OrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  [WordInteropEnumValue("wdOrganizerObjectStyles")]
  Styles = 0,
  /// <summary>
  /// An AutoText item.
  /// </summary>
  [WordInteropEnumValue("wdOrganizerObjectAutoText")]
  AutoText = 1,
  /// <summary>
  /// A command bar item.
  /// </summary>
  [WordInteropEnumValue("wdOrganizerObjectCommandBars")]
  CommandBars = 2,
  /// <summary>
  /// A project item.
  /// </summary>
  [WordInteropEnumValue("wdOrganizerObjectProjectItems")]
  ProjectItems = 3
}
