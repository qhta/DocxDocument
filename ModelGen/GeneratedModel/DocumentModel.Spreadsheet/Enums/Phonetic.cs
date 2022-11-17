namespace DocumentModel.Spreadsheet;

public enum Phonetic
{
  
  [XmlEnum("halfwidthKatakana")]
  HalfWidthKatakana,
  
  [XmlEnum("fullwidthKatakana")]
  FullWidthKatakana,
  
  [XmlEnum("Hiragana")]
  Hiragana,
  
  [XmlEnum("noConversion")]
  NoConversion,
}
