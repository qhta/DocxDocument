namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CryptProviderValues enumeration.
/// </summary>
public enum CryptProviderValues
{
  /// <summary>
  /// AES Provider.
  /// </summary>
  [XmlEnum("rsaAES")]
  RsaAdvancedEncryptionStandard,
  
  /// <summary>
  /// Any Provider.
  /// </summary>
  [XmlEnum("rsaFull")]
  RsaFull,
  
  /// <summary>
  /// custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
}
