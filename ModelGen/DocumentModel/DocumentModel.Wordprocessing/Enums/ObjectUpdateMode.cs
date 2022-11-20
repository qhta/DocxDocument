namespace DocumentModel.Wordprocessing;

/// <summary>
/// Linked Object Update Modes
/// </summary>
public enum ObjectUpdateMode
{
  /// <summary>
  /// always.
  /// </summary>
  [XmlEnum("always")]
  always,
  
  /// <summary>
  /// onCall.
  /// </summary>
  [XmlEnum("onCall")]
  onCall,
  
}
