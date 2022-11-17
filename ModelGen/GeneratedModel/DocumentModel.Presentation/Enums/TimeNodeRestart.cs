namespace DocumentModel.Presentation;

public enum TimeNodeRestart
{

  [XmlEnum("always")]
  Always,

  [XmlEnum("whenNotActive")]
  WhenNotActive,

  [XmlEnum("never")]
  Never,
}
