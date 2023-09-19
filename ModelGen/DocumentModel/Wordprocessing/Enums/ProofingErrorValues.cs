namespace DXW;


/// <summary>
///   Defines the ProofingErrorValues enumeration.
/// </summary>
public enum ProofingErrorValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spellStart&quot;.
  /// </summary>
  [EnumString("spellStart")]
  SpellStart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spellEnd&quot;.
  /// </summary>
  [EnumString("spellEnd")]
  SpellEnd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gramStart&quot;.
  /// </summary>
  [EnumString("gramStart")]
  GrammarStart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gramEnd&quot;.
  /// </summary>
  [EnumString("gramEnd")]
  GrammarEnd,
  
}
