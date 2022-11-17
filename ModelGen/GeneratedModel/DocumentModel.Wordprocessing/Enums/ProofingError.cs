namespace DocumentModel.Wordprocessing;

public enum ProofingError
{
  
  [XmlEnum("spellStart")]
  SpellStart,
  
  [XmlEnum("spellEnd")]
  SpellEnd,
  
  [XmlEnum("gramStart")]
  GrammarStart,
  
  [XmlEnum("gramEnd")]
  GrammarEnd,
}
