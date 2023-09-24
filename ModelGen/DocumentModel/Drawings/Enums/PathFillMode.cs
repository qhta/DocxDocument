namespace DocumentModel.Drawings;


/// <summary>
///   Path Fill Mode
/// </summary>
public enum PathFillMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;norm&quot;.
  /// </summary>
  [EnumString("norm")]
  Norm,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lighten&quot;.
  /// </summary>
  [EnumString("lighten")]
  Lighten,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightenLess&quot;.
  /// </summary>
  [EnumString("lightenLess")]
  LightenLess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;darken&quot;.
  /// </summary>
  [EnumString("darken")]
  Darken,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;darkenLess&quot;.
  /// </summary>
  [EnumString("darkenLess")]
  DarkenLess,
  
}
