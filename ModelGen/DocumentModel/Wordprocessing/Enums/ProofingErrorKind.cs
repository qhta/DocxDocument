namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ProofingErrorValues enumeration.
/// </summary>
public enum ProofingErrorKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spellStart&quot;.
  /// </summary>
  SpellStart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;spellEnd&quot;.
  /// </summary>
  SpellEnd,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gramStart&quot;.
  /// </summary>
  GrammarStart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;gramEnd&quot;.
  /// </summary>
  GrammarEnd,
  
}
