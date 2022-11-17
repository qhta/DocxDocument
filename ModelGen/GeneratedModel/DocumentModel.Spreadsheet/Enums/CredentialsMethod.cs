namespace DocumentModel.Spreadsheet;

public enum CredentialsMethod
{
  
  [XmlEnum("integrated")]
  Integrated,
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("stored")]
  Stored,
}
