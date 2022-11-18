namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the ResourceLinkage enumeration.
/// </summary>
public enum ResourceLinkage
{
  /// <summary>
  /// embed.
  /// </summary>
  [XmlEnum("embed")]
  Embed,
  
  /// <summary>
  /// link.
  /// </summary>
  [XmlEnum("link")]
  Link,
  
  /// <summary>
  /// linkAndEmbed.
  /// </summary>
  [XmlEnum("linkAndEmbed")]
  LinkAndEmbed,
  
}
