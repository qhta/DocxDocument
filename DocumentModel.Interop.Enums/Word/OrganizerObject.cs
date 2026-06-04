namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of object used by a delete, copy, or rename action.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdorganizerobject?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdOrganizerObject))]
public enum OrganizerObject
{
  /// <summary>
  /// A style item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrganizerObject.wdOrganizerObjectStyles))]
  Styles = 0,
  /// <summary>
  /// An AutoText item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrganizerObject.wdOrganizerObjectAutoText))]
  AutoText = 1,
  /// <summary>
  /// A command bar item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrganizerObject.wdOrganizerObjectCommandBars))]
  CommandBars = 2,
  /// <summary>
  /// A project item.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdOrganizerObject.wdOrganizerObjectProjectItems))]
  ProjectItems = 3
}
