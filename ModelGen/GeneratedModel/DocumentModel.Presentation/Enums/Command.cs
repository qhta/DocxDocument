namespace DocumentModel.Presentation;

public enum Command
{

  [XmlEnum("evt")]
  Event,

  [XmlEnum("call")]
  Call,

  [XmlEnum("verb")]
  Verb,
}
