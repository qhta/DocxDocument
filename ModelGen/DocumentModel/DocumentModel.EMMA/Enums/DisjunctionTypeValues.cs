namespace DocumentModel.EMMA;

/// <summary>
/// Defines the DisjunctionTypeValues enumeration.
/// </summary>
public enum DisjunctionTypeValues
{
  /// <summary>
  /// recognition.
  /// </summary>
  [XmlEnum("recognition")]
  Recognition,
  
  /// <summary>
  /// understanding.
  /// </summary>
  [XmlEnum("understanding")]
  Understanding,
  
  /// <summary>
  /// multi-device.
  /// </summary>
  [XmlEnum("multi-device")]
  Multidevice,
  
  /// <summary>
  /// multi-process.
  /// </summary>
  [XmlEnum("multi-process")]
  Multiprocess,
  
}
