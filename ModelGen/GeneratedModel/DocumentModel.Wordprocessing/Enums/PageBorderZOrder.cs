namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorderZOrderValues enumeration.
/// </summary>
public enum PageBorderZOrder
{
  /// <summary>
  /// Page Border Ahead of Text.
  /// </summary>
  [XmlEnum("front")]
  Front,
  
  /// <summary>
  /// Page Border Behind Text.
  /// </summary>
  [XmlEnum("back")]
  Back,
  
}
