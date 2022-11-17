namespace DocumentModel.Wordprocessing;

public enum CharacterSpacing
{
  
  [XmlEnum("doNotCompress")]
  DoNotCompress,
  
  [XmlEnum("compressPunctuation")]
  CompressPunctuation,
  
  [XmlEnum("compressPunctuationAndJapaneseKana")]
  CompressPunctuationAndJapaneseKana,
}
