namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the InfoTextValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.InfoTextValues))]
public enum InfoTextKind
{
  /// <summary>
  ///   Literal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.InfoTextValues.Text))]
  Text,
  /// <summary>
  ///   Glossary Document Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.InfoTextValues.AutoText))]
  AutoText
}