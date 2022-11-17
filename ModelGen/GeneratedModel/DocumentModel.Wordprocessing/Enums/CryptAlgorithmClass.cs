namespace DocumentModel.Wordprocessing;

public enum CryptAlgorithmClass
{

  [XmlEnum("hash")]
  Hash,

  [XmlEnum("custom")]
  Custom,
}
