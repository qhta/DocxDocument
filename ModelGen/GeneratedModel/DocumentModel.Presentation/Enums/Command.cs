namespace DocumentModel.Presentation;

/// <summary>
/// Command Type
/// </summary>
public enum Command
{
  /// <summary>
  /// Command Type Enum ( Event ).
  /// </summary>
  [XmlEnum("evt")]
  Event,
  
  /// <summary>
  /// Command Type Enum ( Call ).
  /// </summary>
  [XmlEnum("call")]
  Call,
  
  /// <summary>
  /// Command Type Enum ( Verb ).
  /// </summary>
  [XmlEnum("verb")]
  Verb,
  
}
