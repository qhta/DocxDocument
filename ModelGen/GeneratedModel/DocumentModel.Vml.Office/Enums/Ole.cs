namespace DocumentModel.Vml.Office;

/// <summary>
/// OLE Connection Type
/// </summary>
public enum Ole
{
  /// <summary>
  /// Embedded Object.
  /// </summary>
  [XmlEnum("Embed")]
  Embed,
  
  /// <summary>
  /// Linked Object.
  /// </summary>
  [XmlEnum("Link")]
  Link,
  
}
