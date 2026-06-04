namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstyletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStyleType")]
public enum StyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeParagraph")]
  Paragraph = 1,
  /// <summary>
  /// Body character style.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeCharacter")]
  Character = 2,
  /// <summary>
  /// Table style.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeTable")]
  Table = 3,
  /// <summary>
  /// List style.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeList")]
  List = 4,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeParagraphOnly")]
  ParagraphOnly = 5,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdStyleTypeLinked")]
  Linked = 6
}
