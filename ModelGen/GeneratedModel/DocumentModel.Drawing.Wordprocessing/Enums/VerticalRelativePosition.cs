namespace DocumentModel.Drawing.Wordprocessing;

public enum VerticalRelativePosition
{
  
  [XmlEnum("margin")]
  Margin,
  
  [XmlEnum("page")]
  Page,
  
  [XmlEnum("paragraph")]
  Paragraph,
  
  [XmlEnum("line")]
  Line,
  
  [XmlEnum("topMargin")]
  TopMargin,
  
  [XmlEnum("bottomMargin")]
  BottomMargin,
  
  [XmlEnum("insideMargin")]
  InsideMargin,
  
  [XmlEnum("outsideMargin")]
  OutsideMargin,
}
