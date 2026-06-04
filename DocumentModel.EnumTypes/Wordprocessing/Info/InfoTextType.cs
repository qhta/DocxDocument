namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the InfoTextValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.InfoTextValues))]
public enum InfoTextType
{
  /// <summary>
  ///   Literal Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.InfoTextValues.Text))]
  Text,
  /// <summary>
  ///   Glossary Document Entry.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.InfoTextValues.AutoText))]
  AutoText
}