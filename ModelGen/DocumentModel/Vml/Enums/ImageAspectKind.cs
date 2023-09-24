namespace DocumentModel.Vml;


/// <summary>
///   Image Scaling Behavior
/// </summary>
public enum ImageAspectKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ignore&quot;.
  /// </summary>
  [EnumString("ignore")]
  Ignore,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;atMost&quot;.
  /// </summary>
  [EnumString("atMost")]
  AtMost,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;atLeast&quot;.
  /// </summary>
  [EnumString("atLeast")]
  AtLeast,
  
}
