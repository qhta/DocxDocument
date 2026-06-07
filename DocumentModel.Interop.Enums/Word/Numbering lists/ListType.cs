namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlisttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdListType")]
public enum ListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  [InteropEnumValue("wdListNoNumbering")]
  NoNumbering = 0,
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  [InteropEnumValue("wdListListNumOnly")]
  ListNumOnly = 1,
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [InteropEnumValue("wdListBullet")]
  Bullet = 2,
  /// <summary>
  /// Simple numeric list.
  /// </summary>
  [InteropEnumValue("wdListSimpleNumbering")]
  SimpleNumbering = 3,
  /// <summary>
  /// Outlined list.
  /// </summary>
  [InteropEnumValue("wdListOutlineNumbering")]
  OutlineNumbering = 4,
  /// <summary>
  /// Mixed numeric list.
  /// </summary>
  [InteropEnumValue("wdListMixedNumbering")]
  MixedNumbering = 5,
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  [InteropEnumValue("wdListPictureBullet")]
  PictureBullet = 6
}
