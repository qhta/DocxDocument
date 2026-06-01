namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the data source Ito be attached Ito the current document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmergesubtype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum MergeSubType
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
  /// Office Address IList.
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

