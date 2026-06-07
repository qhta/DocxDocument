namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstyletype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdStyleType")]
public enum StyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  [InteropEnumValue("wdStyleTypeParagraph")]
  Paragraph = 1,
  /// <summary>
  /// Body character style.
  /// </summary>
  [InteropEnumValue("wdStyleTypeCharacter")]
  Character = 2,
  /// <summary>
  /// Table style.
  /// </summary>
  [InteropEnumValue("wdStyleTypeTable")]
  Table = 3,
  /// <summary>
  /// List style.
  /// </summary>
  [InteropEnumValue("wdStyleTypeList")]
  List = 4,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdStyleTypeParagraphOnly")]
  ParagraphOnly = 5,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdStyleTypeLinked")]
  Linked = 6
}
