namespace DocumentModel.Presentation;

/// <summary>
/// Cryptographic Algorithm Classes
/// </summary>
public enum CryptAlgorithmClass
{
  /// <summary>
  /// Hash Algorithm Class.
  /// </summary>
  [XmlEnum("hash")]
  Hash,
  
  /// <summary>
  /// Invalid Algorithm Class.
  /// </summary>
  [XmlEnum("invalid")]
  Invalid,
  
}
