namespace DocumentModel.Vml.Office;


/// <summary>
///   Callout Angles
/// </summary>
public enum AngleKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;any&quot;.
  /// </summary>
  [EnumString("any")]
  Any,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;30&quot;.
  /// </summary>
  [EnumString("30")]
  Degree30,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;45&quot;.
  /// </summary>
  [EnumString("45")]
  Degree45,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;60&quot;.
  /// </summary>
  [EnumString("60")]
  Degree60,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;90&quot;.
  /// </summary>
  [EnumString("90")]
  Degree90,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;auto&quot;.
  /// </summary>
  [EnumString("auto")]
  Auto,
  
}
