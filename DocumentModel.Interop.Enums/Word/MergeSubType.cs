namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergesubtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMergeSubType))]
public enum MergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeOther))]
  Other = 0,
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeAccess))]
  Access = 1,
  /// <summary>
  /// Office Address List.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeOAL))]
  OAL = 2,
  /// <summary>
  /// OLE database.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeOLEDBWord))]
  OLEDBWord = 3,
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeWorks))]
  Works = 4,
  /// <summary>
  /// OLE database.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeOLEDBText))]
  OLEDBText = 5,
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeOutlook))]
  Outlook = 6,
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeWord))]
  Word = 7,
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMergeSubType.wdMergeSubTypeWord2000))]
  Word2000 = 8
}
