namespace DocumentModel.Wordprocessing;

public enum PageBorderDisplay
{

  [XmlEnum("allPages")]
  AllPages,

  [XmlEnum("firstPage")]
  FirstPage,

  [XmlEnum("notFirstPage")]
  NotFirstPage,
}
