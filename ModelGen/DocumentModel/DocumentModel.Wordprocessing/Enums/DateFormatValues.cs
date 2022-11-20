namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DateFormatValues enumeration.
/// </summary>
public enum DateFormatValues
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
