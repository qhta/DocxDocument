namespace DXW;


/// <summary>
///   Defines the ProofingStateValues enumeration.
/// </summary>
public enum ProofingStateValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;clean&quot;.
  /// </summary>
  [EnumString("clean")]
  Clean,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dirty&quot;.
  /// </summary>
  [EnumString("dirty")]
  Dirty,
  
}
