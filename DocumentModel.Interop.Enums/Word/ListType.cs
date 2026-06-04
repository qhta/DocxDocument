namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlisttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdListType")]
public enum ListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  [WordInteropEnumValue("wdListNoNumbering")]
  NoNumbering = 0,
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  [WordInteropEnumValue("wdListListNumOnly")]
  ListNumOnly = 1,
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [WordInteropEnumValue("wdListBullet")]
  Bullet = 2,
  /// <summary>
  /// Simple numeric list.
  /// </summary>
  [WordInteropEnumValue("wdListSimpleNumbering")]
  SimpleNumbering = 3,
  /// <summary>
  /// Outlined list.
  /// </summary>
  [WordInteropEnumValue("wdListOutlineNumbering")]
  OutlineNumbering = 4,
  /// <summary>
  /// Mixed numeric list.
  /// </summary>
  [WordInteropEnumValue("wdListMixedNumbering")]
  MixedNumbering = 5,
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  [WordInteropEnumValue("wdListPictureBullet")]
  PictureBullet = 6
}
