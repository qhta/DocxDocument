namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.StyleValues))]
public enum StyleType
{
  /// <summary>
  ///   Paragraph Style.
  /// </summary>
  Paragraph,
  /// <summary>
  ///   Character Style.
  /// </summary>
  Character,
  /// <summary>
  ///   Table Style.
  /// </summary>
  Table,
  /// <summary>
  ///   Numbering Style.
  /// </summary>
  Numbering,
  ///// <summary>
  ///// Reserved for internal use.
  ///// </summary>
  //ParagraphOnly = 5,
  ///// <summary>
  ///// Reserved for internal use.
  ///// </summary>
  //Linked = 6
}