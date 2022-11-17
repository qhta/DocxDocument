namespace DocumentModel.Presentation;

public enum TimeNodeSync
{

  [XmlEnum("none")]
  None,

  [XmlEnum("canSlip")]
  CanSlip,

  [XmlEnum("locked")]
  Locked,
}
