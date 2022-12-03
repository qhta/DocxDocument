namespace DocumentModel.Vml;

/// <summary>
/// OLE Connection Type
/// </summary>
public enum OleKind
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
