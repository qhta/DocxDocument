namespace DocumentModel.Vml.Office;


/// <summary>
///   OLE Connection Type
/// </summary>
public enum OleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Embed&quot;.
  /// </summary>
  [EnumString("Embed")]
  Embed,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Link&quot;.
  /// </summary>
  [EnumString("Link")]
  Link,
  
}
