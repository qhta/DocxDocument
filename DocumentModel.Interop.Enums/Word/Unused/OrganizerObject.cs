namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorganizerobject?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdOrganizerObject")]
public enum OrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  [InteropEnumValue("wdOrganizerObjectStyles")]
  Styles = 0,
  /// <summary>
  /// An AutoText item.
  /// </summary>
  [InteropEnumValue("wdOrganizerObjectAutoText")]
  AutoText = 1,
  /// <summary>
  /// A command bar item.
  /// </summary>
  [InteropEnumValue("wdOrganizerObjectCommandBars")]
  CommandBars = 2,
  /// <summary>
  /// A project item.
  /// </summary>
  [InteropEnumValue("wdOrganizerObjectProjectItems")]
  ProjectItems = 3
}
