namespace DocumentModel.Presentation;

public enum SlideSize
{

  [XmlEnum("screen4x3")]
  Screen4x3,

  [XmlEnum("letter")]
  Letter,

  [XmlEnum("A4")]
  A4,

  [XmlEnum("35mm")]
  Film35mm,

  [XmlEnum("overhead")]
  Overhead,

  [XmlEnum("banner")]
  Banner,

  [XmlEnum("custom")]
  Custom,

  [XmlEnum("ledger")]
  Ledger,

  [XmlEnum("A3")]
  A3,

  [XmlEnum("B4ISO")]
  B4ISO,

  [XmlEnum("B5ISO")]
  B5ISO,

  [XmlEnum("B4JIS")]
  B4JIS,

  [XmlEnum("B5JIS")]
  B5JIS,

  [XmlEnum("hagakiCard")]
  HagakiCard,

  [XmlEnum("screen16x9")]
  Screen16x9,

  [XmlEnum("screen16x10")]
  Screen16x10,
}
