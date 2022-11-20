namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
public enum CryptAlgorithmClassValues
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
