namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextBoxFormFieldValues enumeration.
/// </summary>
public enum TextBoxFormFieldValues
{
  /// <summary>
  /// Text Box.
  /// </summary>
  [XmlEnum("regular")]
  Regular,
  
  /// <summary>
  /// Number.
  /// </summary>
  [XmlEnum("number")]
  Number,
  
  /// <summary>
  /// Date.
  /// </summary>
  [XmlEnum("date")]
  Date,
  
  /// <summary>
  /// Current Time Display.
  /// </summary>
  [XmlEnum("currentTime")]
  CurrentTime,
  
  /// <summary>
  /// Current Date Display.
  /// </summary>
  [XmlEnum("currentDate")]
  CurrentDate,
  
  /// <summary>
  /// Field Calculation.
  /// </summary>
  [XmlEnum("calculated")]
  Calculated,
  
}
