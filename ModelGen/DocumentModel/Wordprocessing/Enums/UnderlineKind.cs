namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the UnderlineValues enumeration.
/// </summary>
public enum UnderlineKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;single&quot;.
  /// </summary>
  [EnumString("single")]
  Single,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;words&quot;.
  /// </summary>
  [EnumString("words")]
  Words,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;double&quot;.
  /// </summary>
  [EnumString("double")]
  Double,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;thick&quot;.
  /// </summary>
  [EnumString("thick")]
  Thick,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotted&quot;.
  /// </summary>
  [EnumString("dotted")]
  Dotted,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dottedHeavy&quot;.
  /// </summary>
  [EnumString("dottedHeavy")]
  DottedHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dash&quot;.
  /// </summary>
  [EnumString("dash")]
  Dash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashedHeavy&quot;.
  /// </summary>
  [EnumString("dashedHeavy")]
  DashedHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashLong&quot;.
  /// </summary>
  [EnumString("dashLong")]
  DashLong,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashLongHeavy&quot;.
  /// </summary>
  [EnumString("dashLongHeavy")]
  DashLongHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotDash&quot;.
  /// </summary>
  [EnumString("dotDash")]
  DotDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashDotHeavy&quot;.
  /// </summary>
  [EnumString("dashDotHeavy")]
  DashDotHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dotDotDash&quot;.
  /// </summary>
  [EnumString("dotDotDash")]
  DotDotDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashDotDotHeavy&quot;.
  /// </summary>
  [EnumString("dashDotDotHeavy")]
  DashDotDotHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wave&quot;.
  /// </summary>
  [EnumString("wave")]
  Wave,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wavyHeavy&quot;.
  /// </summary>
  [EnumString("wavyHeavy")]
  WavyHeavy,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wavyDouble&quot;.
  /// </summary>
  [EnumString("wavyDouble")]
  WavyDouble,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
}
