namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
public enum CryptAlgorithmClassKind
{
  /// <summary>
  /// Hashing.
  /// </summary>
  [XmlEnum("hash")]
  Hash,
  
  /// <summary>
  /// custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
