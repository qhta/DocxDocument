namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Split Type
/// </summary>
public enum SplitKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;cust&quot;.
  /// </summary>
  Custom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;percent&quot;.
  /// </summary>
  Percent,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pos&quot;.
  /// </summary>
  Position,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;val&quot;.
  /// </summary>
  Value,
  
}
