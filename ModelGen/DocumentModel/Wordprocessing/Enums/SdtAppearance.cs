namespace DXW;


/// <summary>
///   Defines the SdtAppearance enumeration.
/// </summary>
public enum SdtAppearance
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;boundingBox&quot;.
  /// </summary>
  [EnumString("boundingBox")]
  BoundingBox,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tags&quot;.
  /// </summary>
  [EnumString("tags")]
  Tags,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hidden&quot;.
  /// </summary>
  [EnumString("hidden")]
  Hidden,
  
}
