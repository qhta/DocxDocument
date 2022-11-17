namespace DocumentModel.Office2021.Drawing.DocumentClassification;

public enum ClassificationOutcomeType
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("hdr")]
  Hdr,
  
  [XmlEnum("ftr")]
  Ftr,
  
  [XmlEnum("watermark")]
  Watermark,
}
