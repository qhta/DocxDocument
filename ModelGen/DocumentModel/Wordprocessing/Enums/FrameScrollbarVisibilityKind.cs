namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FrameScrollbarVisibilityValues enumeration.
/// </summary>
public enum FrameScrollbarVisibilityKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;on&quot;.
  /// </summary>
  [EnumString("on")]
  On,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;off&quot;.
  /// </summary>
  [EnumString("off")]
  Off,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
}
