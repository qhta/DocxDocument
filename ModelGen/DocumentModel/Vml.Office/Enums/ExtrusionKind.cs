namespace DocumentModel.Vml.Office;


/// <summary>
///   Extrusion Type
/// </summary>
public enum ExtrusionKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;perspective&quot;.
  /// </summary>
  [EnumString("perspective")]
  Perspective,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;parallel&quot;.
  /// </summary>
  [EnumString("parallel")]
  Parallel,
  
}
