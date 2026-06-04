namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DateFormatValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.DateFormatValues))]
public enum DateFormat
{
  /// <summary>
  ///   Same As Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DateFormatValues.Text))]
  Text,
  /// <summary>
  ///   XML Schema Date Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DateFormatValues.Date))]
  Date,
  /// <summary>
  ///   XML Schema DateTime Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.DateFormatValues.DateTime))]
  DateTime
}