namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the style type to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstyletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdStyleType))]
public enum StyleType
{
  /// <summary>
  /// Paragraph style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeParagraph))]
  Paragraph = 1,
  /// <summary>
  /// Body character style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeCharacter))]
  Character = 2,
  /// <summary>
  /// Table style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeTable))]
  Table = 3,
  /// <summary>
  /// List style.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeList))]
  List = 4,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeParagraphOnly))]
  ParagraphOnly = 5,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStyleType.wdStyleTypeLinked))]
  Linked = 6
}
