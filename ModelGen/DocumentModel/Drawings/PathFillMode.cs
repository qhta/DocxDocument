namespace DocumentModel.Drawings;


/// <summary>
///   Path Fill Mode
/// </summary>
public enum PathFillMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;norm&quot;.
  /// </summary>
  Norm,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lighten&quot;.
  /// </summary>
  Lighten,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lightenLess&quot;.
  /// </summary>
  LightenLess,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;darken&quot;.
  /// </summary>
  Darken,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;darkenLess&quot;.
  /// </summary>
  DarkenLess,
  
}
