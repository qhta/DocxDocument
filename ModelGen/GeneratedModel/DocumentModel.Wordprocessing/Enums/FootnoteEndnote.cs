namespace DocumentModel.Wordprocessing;

public enum FootnoteEndnote
{

  [XmlEnum("normal")]
  Normal,

  [XmlEnum("separator")]
  Separator,

  [XmlEnum("continuationSeparator")]
  ContinuationSeparator,

  [XmlEnum("continuationNotice")]
  ContinuationNotice,
}
