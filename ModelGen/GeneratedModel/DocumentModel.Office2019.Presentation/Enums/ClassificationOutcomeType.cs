namespace DocumentModel.Office2019.Presentation;

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
