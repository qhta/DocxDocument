namespace DocxDocument.Model;

/// <summary>
/// Cryptographic Provider Type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CryptProviderType 
{
  [XmlEnum("RsaAES")]
  RsaAdvancedEncryptionStandard,
  RsaFull,
  Custom,
}