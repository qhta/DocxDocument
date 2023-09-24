namespace DocumentModel.Vml.Office;


/// <summary>
///   OLE Object Representations
/// </summary>
public enum OleDrawAspectKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Content&quot;.
  /// </summary>
  [EnumString("Content")]
  Content,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Icon&quot;.
  /// </summary>
  [EnumString("Icon")]
  Icon,
  
}
