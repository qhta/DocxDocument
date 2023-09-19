namespace DXM;


/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
public enum StyleValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;p&quot;.
  /// </summary>
  [EnumString("p")]
  Plain,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;b&quot;.
  /// </summary>
  [EnumString("b")]
  Bold,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;i&quot;.
  /// </summary>
  [EnumString("i")]
  Italic,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bi&quot;.
  /// </summary>
  [EnumString("bi")]
  BoldItalic,
  
}
