namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of list.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlisttype?view=office-pia` for Office interop details.
/// </remarks>
public enum ListType
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
  /// Bulleted list.
  /// </summary>
  Bullet = 2,
  /// <summary>
  /// Simple numeric list.
  /// </summary>
  SimpleNumbering = 3,
  /// <summary>
  /// Outlined list.
  /// </summary>
  OutlineNumbering = 4,
  /// <summary>
  /// Mixed numeric list.
  /// </summary>
  MixedNumbering = 5,
  /// <summary>
  /// Picture bulleted list.
  /// </summary>
  PictureBullet = 6
}
