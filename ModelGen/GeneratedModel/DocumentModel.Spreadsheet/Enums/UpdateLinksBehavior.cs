namespace DocumentModel.Spreadsheet;

public enum UpdateLinksBehavior
{
  
  [XmlEnum("userSet")]
  UserSet,
  
  [XmlEnum("never")]
  Never,
  
  [XmlEnum("always")]
  Always,
}
