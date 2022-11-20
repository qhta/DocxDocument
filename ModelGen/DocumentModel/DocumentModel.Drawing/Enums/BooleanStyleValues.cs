namespace DocumentModel.Drawing;

/// <summary>
/// On/Off Style Type
/// </summary>
public enum BooleanStyleValues
{
  /// <summary>
  /// On.
  /// </summary>
  [XmlEnum("on")]
  On,
  
  /// <summary>
  /// Off.
  /// </summary>
  [XmlEnum("off")]
  Off,
  
  /// <summary>
  /// Default.
  /// </summary>
  [XmlEnum("def")]
  Default,
  
}
