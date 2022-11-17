namespace DocumentModel.Wordprocessing;

public enum MultiLevel
{
  
  [XmlEnum("singleLevel")]
  SingleLevel,
  
  [XmlEnum("multilevel")]
  Multilevel,
  
  [XmlEnum("hybridMultilevel")]
  HybridMultilevel,
}
