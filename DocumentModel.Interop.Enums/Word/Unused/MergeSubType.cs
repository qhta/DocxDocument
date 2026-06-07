namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergesubtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMergeSubType")]
public enum MergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeOther")]
  Other = 0,
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeAccess")]
  Access = 1,
  /// <summary>
  /// Office Address List.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeOAL")]
  OAL = 2,
  /// <summary>
  /// OLE database.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeOLEDBWord")]
  OLEDBWord = 3,
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeWorks")]
  Works = 4,
  /// <summary>
  /// OLE database.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeOLEDBText")]
  OLEDBText = 5,
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeOutlook")]
  Outlook = 6,
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeWord")]
  Word = 7,
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  [InteropEnumValue("wdMergeSubTypeWord2000")]
  Word2000 = 8
}
