namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DateFormatValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DateFormatValues))]
public enum DateFormat
{
  /// <summary>
  ///   Same As Display.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DateFormatValues.Text))]
  Text,
  /// <summary>
  ///   XML Schema Date Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DateFormatValues.Date))]
  Date,
  /// <summary>
  ///   XML Schema DateTime Format.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DateFormatValues.DateTime))]
  DateTime
}