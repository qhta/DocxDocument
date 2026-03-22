namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
public enum WdListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  wdListNoNumbering = unchecked((int)0),
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  wdListListNumOnly = unchecked((int)1),
  /// <summary>
  /// Bulleted list. wdListSimpleNumbering3 Simple numeric list. wdListOutlineNumbering4 Outlined list.
  /// wdListMixedNumbering5 Mixed numeric list.
  /// </summary>
  wdListBullet = unchecked((int)2),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  wdListSimpleNumbering = unchecked((int)3),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  wdListOutlineNumbering = unchecked((int)4),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  wdListMixedNumbering = unchecked((int)5),
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  wdListPictureBullet = unchecked((int)6)
}
