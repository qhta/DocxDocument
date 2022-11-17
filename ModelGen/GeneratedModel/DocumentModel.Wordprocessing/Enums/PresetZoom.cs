namespace DocumentModel.Wordprocessing;

public enum PresetZoom
{

  [XmlEnum("none")]
  None,

  [XmlEnum("fullPage")]
  FullPage,

  [XmlEnum("bestFit")]
  BestFit,

  [XmlEnum("textFit")]
  TextFit,
}
