namespace DocumentModel.Wordprocessing;

public enum CryptProvider
{
  
  [XmlEnum("rsaAES")]
  RsaAdvancedEncryptionStandard,
  
  [XmlEnum("rsaFull")]
  RsaFull,
  
  [XmlEnum("custom")]
  Custom,
}
