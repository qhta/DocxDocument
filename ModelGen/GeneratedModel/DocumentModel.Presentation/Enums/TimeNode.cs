namespace DocumentModel.Presentation;

public enum TimeNode
{
  
  [XmlEnum("clickEffect")]
  ClickEffect,
  
  [XmlEnum("withEffect")]
  WithEffect,
  
  [XmlEnum("afterEffect")]
  AfterEffect,
  
  [XmlEnum("mainSeq")]
  MainSequence,
  
  [XmlEnum("interactiveSeq")]
  InteractiveSequence,
  
  [XmlEnum("clickPar")]
  ClickParagraph,
  
  [XmlEnum("withGroup")]
  WithGroup,
  
  [XmlEnum("afterGroup")]
  AfterGroup,
  
  [XmlEnum("tmRoot")]
  TmingRoot,
}
