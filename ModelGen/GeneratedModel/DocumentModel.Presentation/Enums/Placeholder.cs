namespace DocumentModel.Presentation;

public enum Placeholder
{

  [XmlEnum("title")]
  Title,

  [XmlEnum("body")]
  Body,

  [XmlEnum("ctrTitle")]
  CenteredTitle,

  [XmlEnum("subTitle")]
  SubTitle,

  [XmlEnum("dt")]
  DateAndTime,

  [XmlEnum("sldNum")]
  SlideNumber,

  [XmlEnum("ftr")]
  Footer,

  [XmlEnum("hdr")]
  Header,

  [XmlEnum("obj")]
  Object,

  [XmlEnum("chart")]
  Chart,

  [XmlEnum("tbl")]
  Table,

  [XmlEnum("clipArt")]
  ClipArt,

  [XmlEnum("dgm")]
  Diagram,

  [XmlEnum("media")]
  Media,

  [XmlEnum("sldImg")]
  SlideImage,

  [XmlEnum("pic")]
  Picture,
}
