namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RangePermissionEditingGroupValues enumeration.
/// </summary>
public enum RangePermissionEditingGroupKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;none&quot;.
  /// </summary>
  None,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;everyone&quot;.
  /// </summary>
  Everyone,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;administrators&quot;.
  /// </summary>
  Administrators,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;contributors&quot;.
  /// </summary>
  Contributors,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;editors&quot;.
  /// </summary>
  Editors,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;owners&quot;.
  /// </summary>
  Owners,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;current&quot;.
  /// </summary>
  Current,
  
}
