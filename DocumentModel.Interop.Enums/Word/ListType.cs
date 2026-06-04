namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlisttype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdListType))]
public enum ListType
{
  /// <summary>
  /// List with no bullets, numbering, or outlining.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListNoNumbering))]
  NoNumbering = 0,
  /// <summary>
  /// ListNum fields that can be used in the body of a paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListListNumOnly))]
  ListNumOnly = 1,
  /// <summary>
  /// Bulleted list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListBullet))]
  Bullet = 2,
  /// <summary>
  /// Simple numeric list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListSimpleNumbering))]
  SimpleNumbering = 3,
  /// <summary>
  /// Outlined list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListOutlineNumbering))]
  OutlineNumbering = 4,
  /// <summary>
  /// Mixed numeric list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListMixedNumbering))]
  MixedNumbering = 5,
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdListType.wdListPictureBullet))]
  PictureBullet = 6
}
