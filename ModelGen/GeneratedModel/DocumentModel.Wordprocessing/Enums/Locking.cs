namespace DocumentModel.Wordprocessing;

public enum Locking
{
  
  [XmlEnum("sdtLocked")]
  SdtLocked,
  
  [XmlEnum("contentLocked")]
  ContentLocked,
  
  [XmlEnum("unlocked")]
  Unlocked,
  
  [XmlEnum("sdtContentLocked")]
  SdtContentLocked,
}
