namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Alignment Types
/// </summary>
public enum PhoneticAlignment
{
  /// <summary>
  /// No Control.
  /// </summary>
  [XmlEnum("noControl")]
  NoControl,
  
  /// <summary>
  /// Left Alignment.
  /// </summary>
  [XmlEnum("left")]
  Left,
  
  /// <summary>
  /// Center Alignment.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Distributed.
  /// </summary>
  [XmlEnum("distributed")]
  Distributed,
  
}
