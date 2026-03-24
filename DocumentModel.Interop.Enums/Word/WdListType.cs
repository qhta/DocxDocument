namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
public enum WdListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  NoNumbering = unchecked((int)0),
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  ListNumOnly = unchecked((int)1),
  /// <summary>
  /// Bulleted list. wdListSimpleNumbering3 Simple numeric list. wdListOutlineNumbering4 Outlined list.
  /// wdListMixedNumbering5 Mixed numeric list.
  /// </summary>
  Bullet = unchecked((int)2),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  SimpleNumbering = unchecked((int)3),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  OutlineNumbering = unchecked((int)4),
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  MixedNumbering = unchecked((int)5),
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  PictureBullet = unchecked((int)6)
}
