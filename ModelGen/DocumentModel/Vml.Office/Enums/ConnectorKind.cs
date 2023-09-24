namespace DocumentModel.Vml.Office;


/// <summary>
///   Connector Type
/// </summary>
public enum ConnectorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;straight&quot;.
  /// </summary>
  [EnumString("straight")]
  Straight,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;elbow&quot;.
  /// </summary>
  [EnumString("elbow")]
  Elbow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;curved&quot;.
  /// </summary>
  [EnumString("curved")]
  Curved,
  
}
