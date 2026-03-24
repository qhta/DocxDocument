namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the data source to be attached to the current document.
/// </summary>
public enum WdMergeSubType
{
  /// <summary>
  /// Other type of data source.
  /// </summary>
  Other = unchecked((int)0),
  /// <summary>
  /// Microsoft Access.
  /// </summary>
  Access = unchecked((int)1),
  /// <summary>
  /// Office Address List.
  /// </summary>
  OAL = unchecked((int)2),
  /// <summary>
  /// OLE database.
  /// </summary>
  OLEDBWord = unchecked((int)3),
  /// <summary>
  /// Microsoft Works.
  /// </summary>
  Works = unchecked((int)4),
  /// <summary>
  /// OLE database.
  /// </summary>
  OLEDBText = unchecked((int)5),
  /// <summary>
  /// Microsoft Outlook.
  /// </summary>
  Outlook = unchecked((int)6),
  /// <summary>
  /// Microsoft Word.
  /// </summary>
  Word = unchecked((int)7),
  /// <summary>
  /// Microsoft Word 2000.
  /// </summary>
  Word2000 = unchecked((int)8)
}
