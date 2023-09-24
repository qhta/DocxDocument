namespace DocumentModel;


/// <summary>
///   Defines the TaskSizesValues enumeration.
/// </summary>
public enum TaskSizesKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;largeMediumSmall&quot;.
  /// </summary>
  [EnumString("largeMediumSmall")]
  LargeMediumSmall,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;largeMedium&quot;.
  /// </summary>
  [EnumString("largeMedium")]
  LargeMedium,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;large&quot;.
  /// </summary>
  [EnumString("large")]
  Large,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;mediumSmall&quot;.
  /// </summary>
  [EnumString("mediumSmall")]
  MediumSmall,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;medium&quot;.
  /// </summary>
  [EnumString("medium")]
  Medium,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;small&quot;.
  /// </summary>
  [EnumString("small")]
  Small,
  
}
