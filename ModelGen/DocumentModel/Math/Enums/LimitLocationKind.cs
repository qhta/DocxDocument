namespace DocumentModel.Math;


/// <summary>
///   Defines the LimitLocationValues enumeration.
/// </summary>
public enum LimitLocationKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;undOvr&quot;.
  /// </summary>
  [EnumString("undOvr")]
  UnderOver,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;subSup&quot;.
  /// </summary>
  [EnumString("subSup")]
  SubscriptSuperscript,
  
}
