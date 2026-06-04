namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergesubtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMergeSubType")]
public enum MergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeOther")]
  Other = 0,
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeAccess")]
  Access = 1,
  /// <summary>
  /// Office Address List.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeOAL")]
  OAL = 2,
  /// <summary>
  /// OLE database.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeOLEDBWord")]
  OLEDBWord = 3,
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeWorks")]
  Works = 4,
  /// <summary>
  /// OLE database.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeOLEDBText")]
  OLEDBText = 5,
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeOutlook")]
  Outlook = 6,
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeWord")]
  Word = 7,
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  [WordInteropEnumValue("wdMergeSubTypeWord2000")]
  Word2000 = 8
}
