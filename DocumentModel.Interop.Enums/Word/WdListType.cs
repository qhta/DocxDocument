namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
public enum WdListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  NoNumbering = 0,
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  ListNumOnly = 1,
  /// <summary>
  /// Bulleted list. wdListSimpleNumbering3 Simple numeric list. wdListOutlineNumbering4 Outlined list.
  /// wdListMixedNumbering5 Mixed numeric list.
  /// </summary>
  Bullet = 2,
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  SimpleNumbering = 3,
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  OutlineNumbering = 4,
  /// <summary>
  /// Specifies a type of list.
  /// </summary>
  MixedNumbering = 5,
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  PictureBullet = 6
}
