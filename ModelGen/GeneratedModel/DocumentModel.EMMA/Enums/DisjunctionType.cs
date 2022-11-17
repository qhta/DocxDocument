namespace DocumentModel.EMMA;

public enum DisjunctionType
{
  
  [XmlEnum("recognition")]
  Recognition,
  
  [XmlEnum("understanding")]
  Understanding,
  
  [XmlEnum("multi-device")]
  Multidevice,
  
  [XmlEnum("multi-process")]
  Multiprocess,
}
