namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
public enum WdMergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  Other = 0,
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  Access = 1,
  /// <summary>
  /// Office Address List.
  /// </summary>
  OAL = 2,
  /// <summary>
  /// OLE database.
  /// </summary>
  OLEDBWord = 3,
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  Works = 4,
  /// <summary>
  /// OLE database.
  /// </summary>
  OLEDBText = 5,
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  Outlook = 6,
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  Word = 7,
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  Word2000 = 8
}
