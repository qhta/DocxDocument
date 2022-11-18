namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DateFormatValues enumeration.
/// </summary>
public enum DateFormat
{
  /// <summary>
  /// Same As Display.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// XML Schema Date Format.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// XML Schema DateTime Format.
  /// </summary>
  [XmlEnum("dateTime")]
  DateTime,
  
}
