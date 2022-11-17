namespace DocumentModel.Presentation;

public enum CryptProvider
{
  
  [XmlEnum("rsaAES")]
  RsaAES,
  
  [XmlEnum("rsaFull")]
  RsaFull,
  
  [XmlEnum("invalid")]
  Invalid,
}
