namespace DocumentModel.Drawing.Wordprocessing;

public enum HorizontalRelativePosition
{

  [XmlEnum("margin")]
  Margin,

  [XmlEnum("page")]
  Page,

  [XmlEnum("column")]
  Column,

  [XmlEnum("character")]
  Character,

  [XmlEnum("leftMargin")]
  LeftMargin,

  [XmlEnum("rightMargin")]
  RightMargin,

  [XmlEnum("insideMargin")]
  InsideMargin,

  [XmlEnum("outsideMargin")]
  OutsideMargin,
}
