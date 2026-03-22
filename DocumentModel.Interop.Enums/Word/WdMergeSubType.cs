namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
public enum WdMergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  wdMergeSubTypeOther = unchecked((int)0),
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  wdMergeSubTypeAccess = unchecked((int)1),
  /// <summary>
  /// Office Address List.
  /// </summary>
  wdMergeSubTypeOAL = unchecked((int)2),
  /// <summary>
  /// OLE database.
  /// </summary>
  wdMergeSubTypeOLEDBWord = unchecked((int)3),
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  wdMergeSubTypeWorks = unchecked((int)4),
  /// <summary>
  /// OLE database.
  /// </summary>
  wdMergeSubTypeOLEDBText = unchecked((int)5),
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  wdMergeSubTypeOutlook = unchecked((int)6),
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  wdMergeSubTypeWord = unchecked((int)7),
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  wdMergeSubTypeWord2000 = unchecked((int)8)
}
