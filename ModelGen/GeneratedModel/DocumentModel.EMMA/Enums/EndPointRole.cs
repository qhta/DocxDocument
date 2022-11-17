namespace DocumentModel.EMMA;

public enum EndPointRole
{

  [XmlEnum("source")]
  Source,

  [XmlEnum("sink")]
  Sink,

  [XmlEnum("reply-to")]
  Replyto,

  [XmlEnum("router")]
  Router,
}
