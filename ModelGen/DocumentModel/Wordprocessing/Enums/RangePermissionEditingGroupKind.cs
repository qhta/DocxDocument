namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
public enum RangePermissionEditingGroupKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  [EnumString("none")]
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;everyone&quot;.
  /// </summary>
  [EnumString("everyone")]
  Everyone,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;administrators&quot;.
  /// </summary>
  [EnumString("administrators")]
  Administrators,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contributors&quot;.
  /// </summary>
  [EnumString("contributors")]
  Contributors,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;editors&quot;.
  /// </summary>
  [EnumString("editors")]
  Editors,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;owners&quot;.
  /// </summary>
  [EnumString("owners")]
  Owners,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;current&quot;.
  /// </summary>
  [EnumString("current")]
  Current,
  
}
