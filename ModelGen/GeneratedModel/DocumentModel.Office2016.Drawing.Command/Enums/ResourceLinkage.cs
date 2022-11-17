namespace DocumentModel.Office2016.Drawing.Command;

public enum ResourceLinkage
{
  
  [XmlEnum("embed")]
  Embed,
  
  [XmlEnum("link")]
  Link,
  
  [XmlEnum("linkAndEmbed")]
  LinkAndEmbed,
}
