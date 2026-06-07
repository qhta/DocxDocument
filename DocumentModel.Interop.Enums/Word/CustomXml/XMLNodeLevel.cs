namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdxmlnodelevel?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdXMLNodeLevel")]
public enum XMLNodeLevel
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [InteropEnumValue("wdXMLNodeLevelInline")]
  Inline = 0,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [InteropEnumValue("wdXMLNodeLevelParagraph")]
  Paragraph = 1,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [InteropEnumValue("wdXMLNodeLevelRow")]
  Row = 2,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [InteropEnumValue("wdXMLNodeLevelCell")]
  Cell = 3
}
