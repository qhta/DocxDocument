namespace DocumentModel.Wordprocessing;

public enum DocGrid
{

  [XmlEnum("default")]
  Default,

  [XmlEnum("lines")]
  Lines,

  [XmlEnum("linesAndChars")]
  LinesAndChars,

  [XmlEnum("snapToChars")]
  SnapToChars,
}
